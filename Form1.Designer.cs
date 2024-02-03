namespace geographical_information_system
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.btnaddmap = new System.Windows.Forms.Button();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackingSystemDataSet = new geographical_information_system.TrackingSystemDataSet();
            this.araclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araclarTableAdapter = new geographical_information_system.TrackingSystemDataSetTableAdapters.AraclarTableAdapter();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aractipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boylamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(26, 12);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(1091, 538);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 0D;
            this.Map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Map_OnMarkerClick);
            // 
            // btnaddmap
            // 
            this.btnaddmap.Location = new System.Drawing.Point(887, 573);
            this.btnaddmap.Name = "btnaddmap";
            this.btnaddmap.Size = new System.Drawing.Size(230, 59);
            this.btnaddmap.TabIndex = 15;
            this.btnaddmap.Text = "ADD MAP";
            this.btnaddmap.UseVisualStyleBackColor = true;
            this.btnaddmap.Click += new System.EventHandler(this.btnaddmap_Click);
            // 
            // txtlicense
            // 
            this.txtlicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicense.Location = new System.Drawing.Point(985, 652);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(132, 28);
            this.txtlicense.TabIndex = 16;
            this.txtlicense.Text = "32,5";
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(985, 680);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(132, 28);
            this.txttype.TabIndex = 17;
            this.txttype.Text = "32,5";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(985, 736);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(132, 28);
            this.txtTo.TabIndex = 19;
            this.txtTo.Text = "32,5";
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Location = new System.Drawing.Point(985, 708);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(132, 28);
            this.txtfrom.TabIndex = 18;
            this.txtfrom.Text = "32,5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(853, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "License plate: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(891, 680);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Car type: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(942, 734);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "To:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(918, 706);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "From: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.aractipiDataGridViewTextBoxColumn,
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.enlemDataGridViewTextBoxColumn,
            this.boylamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.araclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 556);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 243);
            this.dataGridView1.TabIndex = 24;
            // 
            // trackingSystemDataSet
            // 
            this.trackingSystemDataSet.DataSetName = "TrackingSystemDataSet";
            this.trackingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araclarBindingSource
            // 
            this.araclarBindingSource.DataMember = "Araclar";
            this.araclarBindingSource.DataSource = this.trackingSystemDataSet;
            // 
            // araclarTableAdapter
            // 
            this.araclarTableAdapter.ClearBeforeFill = true;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // aractipiDataGridViewTextBoxColumn
            // 
            this.aractipiDataGridViewTextBoxColumn.DataPropertyName = "Aractipi";
            this.aractipiDataGridViewTextBoxColumn.HeaderText = "Aractipi";
            this.aractipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aractipiDataGridViewTextBoxColumn.Name = "aractipiDataGridViewTextBoxColumn";
            // 
            // neredenDataGridViewTextBoxColumn
            // 
            this.neredenDataGridViewTextBoxColumn.DataPropertyName = "Nereden";
            this.neredenDataGridViewTextBoxColumn.HeaderText = "Nereden";
            this.neredenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.neredenDataGridViewTextBoxColumn.Name = "neredenDataGridViewTextBoxColumn";
            // 
            // nereyeDataGridViewTextBoxColumn
            // 
            this.nereyeDataGridViewTextBoxColumn.DataPropertyName = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.HeaderText = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nereyeDataGridViewTextBoxColumn.Name = "nereyeDataGridViewTextBoxColumn";
            // 
            // enlemDataGridViewTextBoxColumn
            // 
            this.enlemDataGridViewTextBoxColumn.DataPropertyName = "Enlem";
            this.enlemDataGridViewTextBoxColumn.HeaderText = "Enlem";
            this.enlemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enlemDataGridViewTextBoxColumn.Name = "enlemDataGridViewTextBoxColumn";
            // 
            // boylamDataGridViewTextBoxColumn
            // 
            this.boylamDataGridViewTextBoxColumn.DataPropertyName = "Boylam";
            this.boylamDataGridViewTextBoxColumn.HeaderText = "Boylam";
            this.boylamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.boylamDataGridViewTextBoxColumn.Name = "boylamDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1130, 811);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtlicense);
            this.Controls.Add(this.btnaddmap);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Button btnaddmap;
        private System.Windows.Forms.TextBox txtlicense;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrackingSystemDataSet trackingSystemDataSet;
        private System.Windows.Forms.BindingSource araclarBindingSource;
        private TrackingSystemDataSetTableAdapters.AraclarTableAdapter araclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aractipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boylamDataGridViewTextBoxColumn;
    }
}

