namespace kapeku
{
    partial class UserControlCariUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCariUtama));
            this.simpleButtonLihat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonLihat
            // 
            this.simpleButtonLihat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLihat.Image")));
            this.simpleButtonLihat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonLihat.Location = new System.Drawing.Point(600, 3);
            this.simpleButtonLihat.Name = "simpleButtonLihat";
            this.simpleButtonLihat.Size = new System.Drawing.Size(180, 32);
            this.simpleButtonLihat.TabIndex = 19;
            this.simpleButtonLihat.Text = "Lihat Data Lokasi Barang";
            this.simpleButtonLihat.Click += new System.EventHandler(this.simpleButtonLihat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(20, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 386);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // UserControlCariUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButtonLihat);
            this.Name = "UserControlCariUtama";
            this.Size = new System.Drawing.Size(897, 496);
           
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonLihat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
