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
    public partial class UserControlDataMasterBarang : UserControl
    {
        private static UserControlDataMasterBarang _instance;
        public static UserControlDataMasterBarang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDataMasterBarang();
                return _instance;
            }
        }
        SqlConnection koneksi;
        string koneksiString;
        public UserControlDataMasterBarang()
        {
            InitializeComponent();
            koneksiString = "Data Source=localhost;Initial Catalog=inventoriDB;Integrated Security=True";
        }

        private void loadMasterBarang()
        {

            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select b.id_barang, b.nama_barang, cast(b.harga as float)as harga from tb_barang b", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            da.Fill(dt);
            bs.DataSource = dt;
            gridControlMasterBarang.DataSource = bs;

            label4.DataBindings.Clear();
            textEditHargaBarang.DataBindings.Clear();
            textEditNamaBarang.DataBindings.Clear();
            textEditNamaBarang.DataBindings.Add("Text", bs, "nama_barang");
            textEditHargaBarang.DataBindings.Add("Text",bs,"harga");
            
            label4.DataBindings.Add("Text", bs, "id_barang");
        }
        private void DetMasterBar()
        {
            string query = "select d.id_det_barang, d.id_barang,d.ukuran,d.jumlah,d.ket_det_barang from tb_det_barang d inner join tb_barang b on d.id_barang = b.id_barang where b.id_barang= @id_barang ";

            koneksi = new SqlConnection(koneksiString);
            SqlCommand koman = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(koman);

            koman.Parameters.Add("@id_barang", SqlDbType.VarChar).Value = label4.Text;
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            adapter.Fill(dt);
            gridControlMasterDetailBarang.DataSource = dt;
            //set bindingsource datasource dan tampilkan ke dalam grid
            bs.DataSource = dt;
            gridControlMasterDetailBarang.DataSource = bs;
            //binding data ke sekarepmu
            textEditJumlahBarDet.DataBindings.Clear();
            
            textEditUkuranBarDet.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            label8.DataBindings.Clear();
            label8.DataBindings.Add("Text", bs, "id_det_barang");
            textEditUkuranBarDet.DataBindings.Add("Text", bs, "ukuran");
            textEditJumlahBarDet.DataBindings.Add("Text", bs, "jumlah");
            textBox1.DataBindings.Add("Text", bs, "ket_det_barang");


        }

        private void UserControlDataMasterBarang_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonLihatData_Click(object sender, EventArgs e)
        {
            try
            {
                bersih1();
                panelControl1.Enabled = false;
                panelControl2.Enabled = false;
                simpleButtonTambahDetail.Enabled = true;
                loadMasterBarang();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButtonTambah_Click(object sender, EventArgs e)
        {
            bersih2();
            panelControl1.Enabled = true;
            simpleButtonSimpan.Enabled = true;
            textEditNamaBarang.Focus();
        }

        private void simpleButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_barang (nama_barang, harga) values('" + textEditNamaBarang.Text + "','" + textEditHargaBarang.Text + "')";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMasterBarang();
                bersih2();
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
                query = "update tb_barang set nama_barang='"+textEditNamaBarang.Text+"', harga='"+textEditHargaBarang.Text+"' where id_barang='"+label4.Text+"';";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMasterBarang();
                bersih2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DeleteDetailMaster()
        {
            try
            {
                string query;
                query = "delete tb_det_barang where id_barang='" + label4.Text + "'";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // iki hapus seko master barang
        private void simpleButtonHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda ingin menghapus data ini ? data di detail juga akan terhapus", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //kodene ning kene jhon
                try
                {
                    string query;
                    query = "delete tb_barang where id_barang='"+label4.Text+"'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteDetailMaster();
                    loadMasterBarang();
                    bersih2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //iki kodinge nyuk
            DetMasterBar();
            simpleButtonHapus.Enabled = true;
            simpleButtonUbah.Enabled = true;
            simpleButtonSimpan.Enabled = false;
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            //iki kodinge nyuk
            DetMasterBar();
            simpleButtonHapus.Enabled = true;
            simpleButtonUbah.Enabled = true;
            simpleButtonSimpan.Enabled = false;
            panelControl1.Enabled = true;
        }

        private void panelControlDataBarang_Paint(object sender, PaintEventArgs e)
        {
            simpleButtonTambahDetail.Enabled = false;
            simpleButtonSimpan.Enabled = false;
            simpleButtonHapus.Enabled = false;
            simpleButtonUbah.Enabled = false;
            simpleButtonUbahDetail.Enabled = false;
            simpleButtonsimpanDetail.Enabled = false;
            simpleButtonHapusDetail.Enabled = false;
            panelControl2.Enabled = false;

            gridControlMasterBarang.DataSource = null;
            gridView2.Columns.Clear();
            gridView3.Columns.Clear();
            bersih1();
            bersih2();
            simpleButtonSimpan.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panelControl2.Enabled = true;
            simpleButtonsimpanDetail.Enabled = true;
            bersih1();
        }
        // iki hapus seko detail barang
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda ingin mengapus data ini ?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string query;
                    query = "delete tb_det_barang where id_det_barang='" + label8.Text + "'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DetMasterBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_det_barang (id_barang, ukuran, jumlah, ket_det_barang) values('" + label4.Text + "','" + textEditUkuranBarDet.Text + "','" + textEditJumlahBarDet.Text + "','" + textBox1.Text + "')";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan","Pesan",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bersih1();
                DetMasterBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //iki bersih nggon DETAIL!!!!!!
        private void bersih1()
        {
            textEditJumlahBarDet.Text = "";           
            textEditUkuranBarDet.Text = "";
            textBox1.Text = "";
        }
        //iki bersih nggone barang!!! ojo kulawik lho
        private void bersih2()
        {
            textEditNamaBarang.Text = "";
            textEditHargaBarang.Text = "";
        }
        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DetMasterBar();
            simpleButtonHapusDetail.Enabled = true;
            simpleButtonUbahDetail.Enabled = true;
        }
        //iki edit data seko detail barang
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
              
                string query;
                query = "update tb_det_barang set ukuran='"+textEditUkuranBarDet.Text+"',jumlah='"+textEditJumlahBarDet.Text+"',ket_det_barang='"+textBox1.Text+"' where id_det_barang='"+label8.Text+"' ;";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DetMasterBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            simpleButtonHapus.Enabled = true;
            simpleButtonUbah.Enabled = true;
            simpleButtonSimpan.Enabled = false;
        }

        private void gridView3_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            simpleButtonUbahDetail.Enabled = true;
            simpleButtonHapusDetail.Enabled = true;
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            simpleButtonUbahDetail.Enabled = true;
            simpleButtonHapusDetail.Enabled = true;
            simpleButtonsimpanDetail.Enabled = false;
            panelControl2.Enabled = true;
        }
    }
}
    
