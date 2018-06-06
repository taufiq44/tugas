using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace kapeku
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private Form1 frm;
        SqlConnection koneksi;
        string koneksiString;
        public XtraForm1(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            koneksiString = "Data Source=localhost;Initial Catalog=inventoriDB;Integrated Security=True";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(koneksiString);
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_karyawan where nik='" + textBox1.Text + "' and nama='" + textBox2.Text + "' and status='admin' ", koneksi);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("selamat anda berhasil login");
                frm.bukakRibbonpage3();
                this.Close();

            }
            else if (count > 0)
            {
                MessageBox.Show("NIK dan Nama tidak boleh sama");
            }
            else
            {
                MessageBox.Show("maaf anda tidak terdaftar dalam admin");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}