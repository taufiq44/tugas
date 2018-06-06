namespace kapeku
{
    partial class UserControlLokasiMaster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLokasiMaster));
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textBoxKeterangan = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEditLokasi = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.simpleButtonTambah = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLihat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHapus = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUbah = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSimpan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLokasi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(357, 15);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(23, 290);
            this.separatorControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(386, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(450, 290);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // textBoxKeterangan
            // 
            this.textBoxKeterangan.Location = new System.Drawing.Point(80, 38);
            this.textBoxKeterangan.Multiline = true;
            this.textBoxKeterangan.Name = "textBoxKeterangan";
            this.textBoxKeterangan.Size = new System.Drawing.Size(199, 117);
            this.textBoxKeterangan.TabIndex = 42;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.groupControl5);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(878, 357);
            this.panelControl1.TabIndex = 11;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(838, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 37);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.panel1);
            this.groupControl5.Controls.Add(this.simpleButtonTambah);
            this.groupControl5.Controls.Add(this.simpleButtonLihat);
            this.groupControl5.Controls.Add(this.simpleButtonHapus);
            this.groupControl5.Controls.Add(this.simpleButtonUbah);
            this.groupControl5.Controls.Add(this.simpleButtonSimpan);
            this.groupControl5.Location = new System.Drawing.Point(16, 15);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(335, 290);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Lokasi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKeterangan);
            this.panel1.Controls.Add(this.textEditLokasi);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(14, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 168);
            this.panel1.TabIndex = 37;
            // 
            // textEditLokasi
            // 
            this.textEditLokasi.Location = new System.Drawing.Point(80, 12);
            this.textEditLokasi.Name = "textEditLokasi";
            this.textEditLokasi.Size = new System.Drawing.Size(151, 20);
            this.textEditLokasi.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Keterangan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Lokasi";
            // 
            // simpleButtonTambah
            // 
            this.simpleButtonTambah.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTambah.Image")));
            this.simpleButtonTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonTambah.Location = new System.Drawing.Point(74, 220);
            this.simpleButtonTambah.Name = "simpleButtonTambah";
            this.simpleButtonTambah.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonTambah.TabIndex = 36;
            this.simpleButtonTambah.Text = "Tambah";
            this.simpleButtonTambah.Click += new System.EventHandler(this.simpleButtonTambah_Click);
            // 
            // simpleButtonLihat
            // 
            this.simpleButtonLihat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLihat.Image")));
            this.simpleButtonLihat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonLihat.Location = new System.Drawing.Point(14, 220);
            this.simpleButtonLihat.Name = "simpleButtonLihat";
            this.simpleButtonLihat.Size = new System.Drawing.Size(54, 58);
            this.simpleButtonLihat.TabIndex = 18;
            this.simpleButtonLihat.Text = "Lihat";
            this.simpleButtonLihat.Click += new System.EventHandler(this.simpleButtonLihat_Click);
            // 
            // simpleButtonHapus
            // 
            this.simpleButtonHapus.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonHapus.Image")));
            this.simpleButtonHapus.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonHapus.Location = new System.Drawing.Point(269, 220);
            this.simpleButtonHapus.Name = "simpleButtonHapus";
            this.simpleButtonHapus.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonHapus.TabIndex = 17;
            this.simpleButtonHapus.Text = "Hapus";
            this.simpleButtonHapus.Click += new System.EventHandler(this.simpleButtonHapus_Click);
            // 
            // simpleButtonUbah
            // 
            this.simpleButtonUbah.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUbah.Image")));
            this.simpleButtonUbah.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonUbah.Location = new System.Drawing.Point(213, 220);
            this.simpleButtonUbah.Name = "simpleButtonUbah";
            this.simpleButtonUbah.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonUbah.TabIndex = 16;
            this.simpleButtonUbah.Text = "Ubah";
            this.simpleButtonUbah.Click += new System.EventHandler(this.simpleButtonUbah_Click);
            // 
            // simpleButtonSimpan
            // 
            this.simpleButtonSimpan.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSimpan.Image")));
            this.simpleButtonSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonSimpan.Location = new System.Drawing.Point(130, 220);
            this.simpleButtonSimpan.Name = "simpleButtonSimpan";
            this.simpleButtonSimpan.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonSimpan.TabIndex = 15;
            this.simpleButtonSimpan.Text = "Simpan";
            this.simpleButtonSimpan.Click += new System.EventHandler(this.simpleButtonSimpan_Click);
            // 
            // UserControlLokasiMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UserControlLokasiMaster";
            this.Size = new System.Drawing.Size(894, 388);
            this.Load += new System.EventHandler(this.UserControlLokasiMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLokasi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox textBoxKeterangan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEditLokasi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTambah;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLihat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHapus;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUbah;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSimpan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
