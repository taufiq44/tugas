using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kapeku
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItemCariLetakBRG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlCariUtama.Instance))
            {
                panelUtama.Controls.Add(UserControlCariUtama.Instance);
                UserControlCariUtama.Instance.Dock = DockStyle.Fill;
                UserControlCariUtama.Instance.BringToFront();
            }
            else UserControlCariUtama.Instance.BringToFront();
        }

        private void barButtonItemMasterBRG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlDataMasterBarang.Instance))
            {
                panelUtama.Controls.Add(UserControlDataMasterBarang.Instance);
                UserControlDataMasterBarang.Instance.Dock = DockStyle.Fill;
                UserControlDataMasterBarang.Instance.BringToFront();
                //UserControlDataMasterBarang baru = new UserControlDataMasterBarang();
                //baru.DataBindings = null;

            }
            else UserControlDataMasterBarang.Instance.BringToFront();

        }

        private void barButtonItemLokasiMasterBrg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             if (!panelUtama.Controls.Contains(UserControlLokasiMaster.Instance))
            {
                panelUtama.Controls.Add(UserControlLokasiMaster.Instance);
                UserControlLokasiMaster.Instance.Dock = DockStyle.Fill;
                UserControlLokasiMaster.Instance.BringToFront();
            }
            else UserControlLokasiMaster.Instance.BringToFront();
        }

        private void barButtonItemKaryawanMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlMasterKaryawan.Instance))
            {
                panelUtama.Controls.Add(UserControlMasterKaryawan.Instance);
                UserControlMasterKaryawan.Instance.Dock = DockStyle.Fill;
                UserControlMasterKaryawan.Instance.BringToFront();
            }
            else UserControlMasterKaryawan.Instance.BringToFront();
        }

        private void barButtonItemExitApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari aplikasi ini ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barButtonItemTentangApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Aplikasi ini di buat untuk " +
                            "membantu komputasi inventori Gudang Toko Mirasa    Copyright ©, All Rights Reserved.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlCariUtama.Instance))
            {
                panelUtama.Controls.Add(UserControlCariUtama.Instance);
                UserControlCariUtama.Instance.Dock = DockStyle.Fill;
                UserControlCariUtama.Instance.BringToFront();
            }
            else UserControlCariUtama.Instance.BringToFront();
        }

        private void barButtonItemLokasiBarang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlLokasiBarang.Instance))
            {
                panelUtama.Controls.Add(UserControlLokasiBarang.Instance);
                UserControlLokasiBarang.Instance.Dock = DockStyle.Fill;
                UserControlLokasiBarang.Instance.BringToFront();
            }
            else UserControlLokasiBarang.Instance.BringToFront();
            
        }

        private void barButtonItemBRGMasuk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlBarangMasuk.Instance))
            {
                panelUtama.Controls.Add(UserControlBarangMasuk.Instance);
                UserControlBarangMasuk.Instance.Dock = DockStyle.Fill;
                UserControlBarangMasuk.Instance.BringToFront();
            }
            else UserControlBarangMasuk.Instance.BringToFront();
        }

        private void barButtonItemBRGKeluar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelUtama.Controls.Contains(UserControlBarangKeluar.Instance))
            {
                panelUtama.Controls.Add(UserControlBarangKeluar.Instance);
                UserControlBarangKeluar.Instance.Dock = DockStyle.Fill;
                UserControlBarangKeluar.Instance.BringToFront();
            }
            else UserControlBarangKeluar.Instance.BringToFront();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             if (!panelUtama.Controls.Contains(UserControlLaporanBRGmasuk.Instance))
            {
                panelUtama.Controls.Add(UserControlLaporanBRGmasuk.Instance);
                UserControlLaporanBRGmasuk.Instance.Dock = DockStyle.Fill;
                UserControlLaporanBRGmasuk.Instance.BringToFront();
            }
            else UserControlLaporanBRGmasuk.Instance.BringToFront();
        }

        private void barButtonItemLaporanBRGkeluar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (!panelUtama.Controls.Contains(UserControlLaporanBRGkeluar.Instance))
            {
                panelUtama.Controls.Add(UserControlLaporanBRGkeluar.Instance);
                UserControlLaporanBRGkeluar.Instance.Dock = DockStyle.Fill;
                UserControlLaporanBRGkeluar.Instance.BringToFront();
            }
            else UserControlLaporanBRGkeluar.Instance.BringToFront();
        }

        private void barButtonItemLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm1 xtraform = new XtraForm1(this);
            xtraform.ShowDialog();
        }
        public void bukakRibbonpage3()
        {
            ribbonPage3.Visible = true;
                     
        }

        private void barButtonItemLOGOUT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Anda ingin keluar dari admin ?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                    ribbonPage3.Visible = false;
                    ribbonPage2.Visible = true;

                barButtonItemCariLetakBRG.PerformClick();
            
            }

        }

    }
}
