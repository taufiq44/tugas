using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapeku
{
    public partial class UserControlLaporanBRGkeluar : UserControl
    {
        private static UserControlLaporanBRGkeluar _instance;
        public static UserControlLaporanBRGkeluar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLaporanBRGkeluar();
                return _instance;
            }
        }

        public UserControlLaporanBRGkeluar()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.tb_brg_keluarTableAdapter.Fill(this.DataSet1.tb_brg_keluar, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
