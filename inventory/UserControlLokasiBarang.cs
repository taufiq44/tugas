using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kapeku
{
    public partial class UserControlLokasiBarang : UserControl
    {

        private static UserControlLokasiBarang _instance;
        public static UserControlLokasiBarang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLokasiBarang();
                return _instance;
            }
        }
        
        SqlConnection koneksi;
        string koneksiString;
        public UserControlLokasiBarang()
        {
            InitializeComponent();
            koneksiString = "Data Source = localhost; Initial Catalog = inventoriDB; Integrated Security = True";
            panel2.Enabled = false;
        }

        private void LoadDataPenyimpanan()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter(" select tb_penyimpanan.id_penyimpanan, tb_lokasi.nama_lokasi, tb_barang.id_barang, tb_barang.nama_barang from tb_penyimpanan join tb_lokasi on tb_lokasi.nama_lokasi = tb_penyimpanan.id_lokasi join tb_barang on tb_barang.id_barang = tb_penyimpanan.id_barang", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControl1.DataSource = bs;

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            label3.DataBindings.Clear();
            label4.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", bs, "nama_lokasi");
            textBox2.DataBindings.Add("Text", bs, "nama_barang");
            label3.DataBindings.Add("Text", bs, "id_barang");
            label4.DataBindings.Add("Text", bs, "id_penyimpanan");
        }

        private void LoadBarang()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select id_barang, nama_barang from tb_barang ", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;

           
            textBox2.DataBindings.Clear();
            label3.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", bs, "nama_barang", true, DataSourceUpdateMode.OnPropertyChanged);
            label3.DataBindings.Add("Text", bs, "id_barang");
           
        }
       
        private void LoadLokasi()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select nama_lokasi from tb_lokasi ", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", bs, "nama_lokasi");
           
          
          //  bs.DataSource = dt;
            // gridControl1.DataSource = bs;
        }
        private void ngeloadBarangTambah()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select id_barang, nama_barang from tb_barang ", koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void ngeloadLokasiTambah()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select nama_lokasi from tb_lokasi ", koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void simpleButtonLihat_Click(object sender, EventArgs e)
        {
            LoadDataPenyimpanan();
            simpleButtonSimpan.Enabled = false;
        }
        private void simpleButtonTambah_Click(object sender, EventArgs e)
        {
            simpleButtonHapus.Enabled = false;
            simpleButtonUbah.Enabled = false;
            simpleButtonSimpan.Enabled = true;
            bersihSemua();
        }
        //dong to diresiki kabeh ??
        private void bersihSemua()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
        private void UserControlLokasiBarang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            dataGridView2.Columns.Clear();

        }     
        private void UserControlLokasiBarang_Paint(object sender, PaintEventArgs e)
        {
           gridControl1.DataSource = null;
           dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
           
        }

        private void listBoxBarang_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            simpleButtonHapus.Enabled = true;
            simpleButtonUbah.Enabled = true;
            simpleButtonSimpan.Enabled = false;
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        //iki ngeload barang karo lokasi tok til lho
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            LoadBarang();
            LoadLokasi();
        }

        private void simpleButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_penyimpanan (id_lokasi, id_barang) values ('"+textBox1.Text+"','"+label3.Text+"')";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihSemua();
                LoadDataPenyimpanan();
                
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
                query = "update tb_penyimpanan set id_lokasi = '"+textBox1.Text+"', id_barang = '"+label3.Text+"' where id_ = '"+label4.Text+"'";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihSemua();
                LoadDataPenyimpanan();
               
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
                    query = "delete tb_penyimpanan where id_penyimpanan = '" + label4.Text + "'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihSemua();
                    LoadDataPenyimpanan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
