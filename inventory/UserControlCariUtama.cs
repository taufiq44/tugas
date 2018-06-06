using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapeku
{
    public partial class UserControlCariUtama : UserControl
    {
        private static UserControlCariUtama _instance;
        public static UserControlCariUtama Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlCariUtama();
                return _instance;
                
            }
            
        }
        SqlConnection koneksi;
        string koneksiString;
        public UserControlCariUtama()
        {
            InitializeComponent();
            koneksiString = "Data Source = localhost; Initial Catalog = inventoriDB; Integrated Security = True";
        }

        private void lihatData()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter(" select tb_penyimpanan.id_penyimpanan, tb_lokasi.nama_lokasi, tb_barang.id_barang, tb_barang.nama_barang from tb_penyimpanan join tb_lokasi on tb_lokasi.nama_lokasi = tb_penyimpanan.id_lokasi join tb_barang on tb_barang.id_barang = tb_penyimpanan.id_barang", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControl1.DataSource = bs;
            //gridControl2.DataSource = bs;
        }
       

        private void simpleButtonLihat_Click(object sender, EventArgs e)
        {
            lihatData();
        }

       
    }
}
