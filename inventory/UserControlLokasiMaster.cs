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
    public partial class UserControlLokasiMaster : UserControl
    {

        private static UserControlLokasiMaster _instance;
        public static UserControlLokasiMaster Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLokasiMaster();
                return _instance;
            }
        }
        SqlConnection koneksi;
        string koneksiString;
        public UserControlLokasiMaster()
        {
            InitializeComponent();
            koneksiString = "Data Source = localhost; Initial Catalog = inventoriDB; Integrated Security = True";
        }
        // iki nek arep njimuk data ko database
        private void loadData()
        {
            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_lokasi", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControl1.DataSource = bs;

            textEditLokasi.DataBindings.Clear();
            textBoxKeterangan.DataBindings.Clear();
            textEditLokasi.DataBindings.Add("Text", bs, "nama_lokasi");
            textBoxKeterangan.DataBindings.Add("Text", bs, "ket_lokasi");
        }
        private void bersih()
        {
            textEditLokasi.Text = "";
            textBoxKeterangan.Text = "";
        }
        private void UserControlLokasiMaster_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;


            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
        }

        private void simpleButtonTambah_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            simpleButtonSimpan.Enabled = true;
            textEditLokasi.Focus();
            textEditLokasi.Enabled = true;
            simpleButtonHapus.Enabled = false;
            simpleButtonUbah.Enabled = false;
            bersih();
        }

        private void simpleButtonLihat_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void simpleButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_lokasi (nama_lokasi, ket_lokasi) values('" + textEditLokasi.Text + "','" + textBoxKeterangan.Text + "'); ";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                loadData();
                
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
                query = "update tb_lokasi set ket_lokasi='" + textBoxKeterangan.Text + "'  where nama_lokasi='" + textEditLokasi.Text + "'; ";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                loadData();
                
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
                    query = "delete tb_lokasi where nama_lokasi = '" + textEditLokasi.Text + "'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            panel1.Enabled = true;
            textEditLokasi.Enabled = false;
            simpleButtonSimpan.Enabled = false;
            simpleButtonUbah.Enabled = true;
            simpleButtonHapus.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama Lokasi tidak boleh sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            panel1.Enabled = true;
            textEditLokasi.Enabled = false;
            simpleButtonSimpan.Enabled = false;
            simpleButtonUbah.Enabled = true;
            simpleButtonHapus.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Enabled = false;

            
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            bersih();
        }
    }
}
