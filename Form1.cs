using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.MapProviders.StrucRoads.SnappedPoint;

namespace geographical_information_system
{
    public partial class Form1 : Form
    {


         GMapOverlay layer1;
        List<Car> List;
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-HP2NA5H\SQLEXPRESS;Initial Catalog=TrackingSystem;Integrated Security=True");



        public Form1()
        {
            InitializeComponent();
            InitializeMap();
            MakeCarList();
            

        }


        private void MakeCarList()
        {
            List = new List<Car>();
            // Veritabanından ADO.NET ile bilgilerin cekilmesi
            try { 

                connect.Open();
                string sqltext = " SELECT Plaka, Cartype, Nereden, Nereye, Enlem, Boylam FROM Araclar";
                SqlDataAdapter da = new SqlDataAdapter(sqltext, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0 )
                {
                    dataGridView1.DataSource = dt;
                }

                for (int i=0; i<dt.Rows.Count; i++)
                {
                    List.Add(new Car(dt.Rows[i][0].ToString(),
                                     dt.Rows[i][1].ToString(),
                                     dt.Rows[i][2].ToString(),
                                     dt.Rows[i][3].ToString(),
                                     new PointLatLng(Convert.ToDouble(dt.Rows[i][4].ToString()),
                                     Convert.ToDouble(dt.Rows[i][5].ToString()))));



                }



            }
            catch(Exception ex) {

                MessageBox.Show("database error, ERROR: 4001\n" + 
                    ex.Message);
            
            }
            finally { 
                if (connect != null) {
                    connect.Close();
                }
            

            }
        }

        private void InitializeMap()
        {
            Map.DragButton = MouseButtons.Left; // key change to zoom in
            Map.MapProvider = GMapProviders.GoogleMap;
            //Map.MapProvider = GMapProviders.GoogleHybridMap; // başka harita çeşidi
            Map.Position = new GMap.NET.PointLatLng(36.0, 42.0);
            Map.Zoom = 4;
            Map.MinZoom = 3;
            Map.MaxZoom = 23;
            layer1 = new GMapOverlay();

            // Bir overlay(katman) oluşturmamız lazım
            // Harita uzerınden goruntulenecek tum componentleri bu katman(overlay) eklememiz gerekmekte
            // GMapOverlay layer1 = new GMapOverlay(); 

            // ilk olarak da yeni oluşturdugumuz katmanı harita nesnemıze eklemelıyız
            Map.Overlays.Add(layer1);

        }

      

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // formu kapattıktan sonra takılı kalmadan kapatmayı sağlar
        {
            Map.Dispose();
            Application.Exit();
        }

      

        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // int markerId = (int)item.Tag;  
            // Console.WriteLine(" id: "+markerId + ", Marker was clicked");
            string selectcarlicenseplate = (string)item.Tag;
            foreach(Car car in List)
            {
                if (selectcarlicenseplate.Equals(car.Carlicenseplate))
                {
                    txtlicense.Text = car.Carlicenseplate;
                    txttype.Text = car.Cartype;
                    txtfrom.Text = car.From;    
                    txtTo.Text = car.To;
                    break;
                }
            }

        }



        private void btnaddmap_Click(object sender, EventArgs e)
        {
            foreach (Car car in List)
            {
                GMarkerGoogle markertemp = new GMarkerGoogle(car.Location, GMarkerGoogleType.green_dot);
                markertemp.Tag = car.Carlicenseplate;
                markertemp.ToolTipText = car.ToString();
                layer1.Markers.Add(markertemp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'trackingSystemDataSet.Araclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araclarTableAdapter.Fill(this.trackingSystemDataSet.Araclar);

        }
    }
}
