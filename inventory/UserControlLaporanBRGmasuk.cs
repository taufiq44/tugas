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
    public partial class UserControlLaporanBRGmasuk : UserControl
    {

        private static UserControlLaporanBRGmasuk _instance;
        public static UserControlLaporanBRGmasuk Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLaporanBRGmasuk();
                return _instance;
            }
        }

        public UserControlLaporanBRGmasuk()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            this.tb_brg_masukTableAdapter.Fill(this.DataSet1.tb_brg_masuk, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            this.reportViewer1.RefreshReport();

        }
    }
}
