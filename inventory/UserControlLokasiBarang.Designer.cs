namespace kapeku
{
    partial class UserControlLokasiBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLokasiBarang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButtonTambah = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLihat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHapus = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUbah = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSimpan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panelControl2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 497);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 261);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(811, 200);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox3);
            this.panelControl2.Location = new System.Drawing.Point(461, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(353, 252);
            this.panelControl2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.simpleButtonTambah);
            this.groupBox3.Controls.Add(this.simpleButtonLihat);
            this.groupBox3.Controls.Add(this.simpleButtonHapus);
            this.groupBox3.Controls.Add(this.simpleButtonUbah);
            this.groupBox3.Controls.Add(this.simpleButtonSimpan);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 237);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Penyimpanan Barang";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 100);
            this.panel2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "label4 Key Penyimpanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "iki label 3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 21);
            this.textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nama Lokasi";
            // 
            // simpleButtonTambah
            // 
            this.simpleButtonTambah.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTambah.Image")));
            this.simpleButtonTambah.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonTambah.Location = new System.Drawing.Point(77, 144);
            this.simpleButtonTambah.Name = "simpleButtonTambah";
            this.simpleButtonTambah.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonTambah.TabIndex = 50;
            this.simpleButtonTambah.Text = "Tambah";
            this.simpleButtonTambah.Click += new System.EventHandler(this.simpleButtonTambah_Click);
            // 
            // simpleButtonLihat
            // 
            this.simpleButtonLihat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLihat.Image")));
            this.simpleButtonLihat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonLihat.Location = new System.Drawing.Point(17, 144);
            this.simpleButtonLihat.Name = "simpleButtonLihat";
            this.simpleButtonLihat.Size = new System.Drawing.Size(54, 58);
            this.simpleButtonLihat.TabIndex = 49;
            this.simpleButtonLihat.Text = "Lihat";
            this.simpleButtonLihat.Click += new System.EventHandler(this.simpleButtonLihat_Click);
            // 
            // simpleButtonHapus
            // 
            this.simpleButtonHapus.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonHapus.Image")));
            this.simpleButtonHapus.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonHapus.Location = new System.Drawing.Point(258, 144);
            this.simpleButtonHapus.Name = "simpleButtonHapus";
            this.simpleButtonHapus.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonHapus.TabIndex = 48;
            this.simpleButtonHapus.Text = "Hapus";
            this.simpleButtonHapus.Click += new System.EventHandler(this.simpleButtonHapus_Click);
            // 
            // simpleButtonUbah
            // 
            this.simpleButtonUbah.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUbah.Image")));
            this.simpleButtonUbah.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonUbah.Location = new System.Drawing.Point(202, 144);
            this.simpleButtonUbah.Name = "simpleButtonUbah";
            this.simpleButtonUbah.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonUbah.TabIndex = 47;
            this.simpleButtonUbah.Text = "Ubah";
            this.simpleButtonUbah.Click += new System.EventHandler(this.simpleButtonUbah_Click);
            // 
            // simpleButtonSimpan
            // 
            this.simpleButtonSimpan.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSimpan.Image")));
            this.simpleButtonSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonSimpan.Location = new System.Drawing.Point(133, 144);
            this.simpleButtonSimpan.Name = "simpleButtonSimpan";
            this.simpleButtonSimpan.Size = new System.Drawing.Size(50, 58);
            this.simpleButtonSimpan.TabIndex = 46;
            this.simpleButtonSimpan.Text = "Simpan";
            this.simpleButtonSimpan.Click += new System.EventHandler(this.simpleButtonSimpan_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(452, 252);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(261, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(180, 31);
            this.simpleButton1.TabIndex = 53;
            this.simpleButton1.Text = "Lihat Lokasi dan Barang";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(192, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Barang";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(243, 197);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Lokasi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(175, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // UserControlLokasiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlLokasiBarang";
            this.Size = new System.Drawing.Size(846, 521);
            this.Load += new System.EventHandler(this.UserControlLokasiBarang_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlLokasiBarang_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTambah;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLihat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHapus;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUbah;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSimpan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}
