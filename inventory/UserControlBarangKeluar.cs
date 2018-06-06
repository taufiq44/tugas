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
    public partial class UserControlBarangKeluar : UserControl
    {
        private static UserControlBarangKeluar _instance;
        public static UserControlBarangKeluar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlBarangKeluar();
                return _instance;
            }
        }
        SqlConnection koneksi;
        string koneksiString;
        public UserControlBarangKeluar()
        {
            InitializeComponent();
            koneksiString = "Data Source=localhost;Initial Catalog=inventoriDB;Integrated Security=True";
        }
        private void lihatBarangMaster()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select d.id_det_barang, d.id_barang, b.nama_barang, d.jumlah, CAST(b.harga as float) as 'harga', d.ukuran, d.ket_det_barang from tb_det_barang d inner join tb_barang b on b.id_barang = d.id_barang ", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControl1.DataSource = bs;

            gridView1.Columns[0].Width = 60;
            gridView1.Columns[1].Width = 60;
            gridView1.Columns[2].Width = 160;
            gridView1.Columns[3].Width = 40;
            gridView1.Columns[4].Width = 60;
            gridView1.Columns[5].Width = 50;
            gridView1.Columns[6].Width = 190;

            textEdit1.DataBindings.Clear();
            textEdit2.DataBindings.Clear();
            textEdit4.DataBindings.Clear();
            textEdit3.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            labelControl1.DataBindings.Clear();
            label7.DataBindings.Clear();
            label8.DataBindings.Clear();

            textEdit1.DataBindings.Add("Text", bs, "nama_barang");
            // textEdit2.DataBindings.Add();
            textEdit4.DataBindings.Add("Text", bs, "harga");
            textEdit3.DataBindings.Add("Text", bs, "ukuran");
            //dateEdit1.DataBindings.Add();
            //textBox1.DataBindings.Add();
            labelControl1.DataBindings.Add("Text", bs, "jumlah");
            label7.DataBindings.Add("Text", bs, "id_det_barang");
            label8.DataBindings.Add("Text", bs, "id_barang");
        }

        private void lihatBarangMasuk()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select d.id_brg_keluar, b.nama_barang, d.jumlah_keluar, CAST(d.harga_keluar as float) as 'harga', d.ukuran, CAST(d.tanggal_keluar as date) as 'tanggal', d.ket from tb_brg_keluar d inner join tb_barang b on b.id_barang = d.id_barang", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControl2.DataSource = bs;

            gridView2.Columns[0].Width = 60;

            textEdit1.DataBindings.Clear();
            textEdit2.DataBindings.Clear();
            textEdit4.DataBindings.Clear();
            textEdit3.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            labelControl1.DataBindings.Clear();
            label7.DataBindings.Clear();
            //  label8.DataBindings.Clear();

            textEdit1.DataBindings.Add("Text", bs, "nama_barang");
            textEdit2.DataBindings.Add("Text", bs, "jumlah_keluar");
            textEdit4.DataBindings.Add("Text", bs, "harga");
            textEdit3.DataBindings.Add("Text", bs, "ukuran");
            dateEdit1.DataBindings.Add("Text", bs, "tanggal");
            textBox1.DataBindings.Add("Text", bs, "ket");
            // labelControl1.DataBindings.Add("Text", bs, "jumlah");
            label7.DataBindings.Add("Text", bs, "id_brg_keluar");
            //label8.DataBindings.Add("Text", bs, "id_barang");
        }
        private void bersih()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit4.Text = " ";
            textEdit3.Text = "";
            dateEdit1.Text = "";
            textBox1.Text = "";
            labelControl1.Text = "00";
            label7.Text = "";
            label8.Text = "";
        }
        private void UserControlBarangKeluar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonLihatData_Click(object sender, EventArgs e)
        {

        }
        // iki lihat data barang keluar
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bersih();
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            lihatBarangMasuk();
            simpleButtonUbah.Enabled = false;
            simpleButtonHapus.Enabled = false;
        }
        // nek iki lihat barang MASTER LHO !!!!!
        private void simpleButtonLihatData_Click_1(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            gridView2.Columns.Clear();
            textEdit1.Enabled = false;
            bersih();
            lihatBarangMaster();
            simpleButtonSimpan.Enabled = true;
            simpleButtonHapus.Enabled = false;
            simpleButtonUbah.Enabled = false;
        }

        private void simpleButtonTambah_Click(object sender, EventArgs e)
        {
            simpleButtonHapus.Enabled = false;
            simpleButtonSimpan.Enabled = true;
            simpleButtonUbah.Enabled = false;
            textEdit1.Enabled = true;
            // gridControl1.DataSource = null;
            bersih();
        }

        private void simpleButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_brg_keluar (id_barang,jumlah_keluar,harga_keluar,ukuran,tanggal_keluar,ket) values('" + label8.Text + "','" + textEdit2.Text + "','" + textEdit4.Text + "','" + textEdit3.Text + "','" + dateEdit1.Text + "','" + textBox1.Text + "')";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lihatBarangMasuk();
                bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {

                string query;
                query = "update tb_brg_keluar set jumlah_keluar='" + textEdit2.Text + "', harga_keluar='" + textEdit4.Text + "', ukuran='" + textEdit3.Text + "', tanggal_keluar='" + dateEdit1.Text + "', ket='" + textBox1.Text + "' where id_brg_keluar='" + label7.Text + "' ;";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lihatBarangMasuk();
                bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButtonHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda ingin menghapus data ini ?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //kodene ning kene jhon
                try
                {
                    string query;
                    query = "delete tb_brg_keluar where id_brg_keluar='" + label7.Text + "'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lihatBarangMasuk();
                    bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            simpleButtonHapus.Enabled = true;
            simpleButtonSimpan.Enabled = false;
            simpleButtonUbah.Enabled = true;
            textEdit1.Enabled = false;
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            simpleButtonHapus.Enabled = true;
            simpleButtonSimpan.Enabled = false;
            simpleButtonUbah.Enabled = true;
            textEdit1.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
