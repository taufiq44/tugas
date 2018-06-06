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
    public partial class UserControlMasterKaryawan : UserControl
    {
        private static UserControlMasterKaryawan _instance;
        public static UserControlMasterKaryawan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlMasterKaryawan();
                return _instance;
            }
        }
 
        SqlConnection koneksi;
        string koneksiString;
        string gender;
        public UserControlMasterKaryawan()
        {
            InitializeComponent();
            koneksiString = "Data Source=localhost;Initial Catalog=inventoriDB;Integrated Security=True";
        }
        private void LoadDataKaryawan()
        {
            DataTable dt = new DataTable();
            dt.Clear();

            koneksi = new SqlConnection(koneksiString);
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_karyawan", koneksi);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            
            BindingSource bs = new BindingSource();
           
            da.Fill(dt);
            bs.DataSource = dt;
            //dataGridView1.DataSource = bs;
            gridControl1.DataSource = bs;

            //bindingkan data ke yang diinginkan
            textEditNama.DataBindings.Clear();
            textEditNIK.DataBindings.Clear();            
            textEditNoHP.DataBindings.Clear();
            textBoxAlamat.DataBindings.Clear();
           // checkEdit1.DataBindings.Clear();

            textEditNama.DataBindings.Add("Text", bs, "nama");
            textEditNIK.DataBindings.Add("Text", bs, "nik");
            textEditNoHP.DataBindings.Add("Text", bs, "no_hp");
            textBoxAlamat.DataBindings.Add("Text", bs, "alamat");
            //checkEdit1.DataBindings.Add("checked", bs, "jk");         
        }
        private void bersihsemua()
        {
            checkEdit1.Checked = false;
            checkEdit2.Checked = false;
            checkEdit3.Checked = false;
            checkEdit4.Checked = false;

            textEditNIK.Text = "";
            textEditNama.Text = "";
            textEditNoHP.Text = "";
            textBoxAlamat.Text = "";
        }
        private void UserControlMasterKaryawan_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            panel1.Enabled = false;
            simpleButtonUbah.Enabled = false;
            simpleButtonHapus.Enabled = false;
            simpleButtonSimpan.Enabled = false;
        }
        //iki button nambah data
        private void simpleButtonTambah_Click(object sender, EventArgs e)
        {
            bersihsemua();
            simpleButtonHapus.Enabled = false;
            simpleButtonUbah.Enabled = false;
            panel1.Enabled = true;
            simpleButtonSimpan.Enabled = true;
            textEditNIK.Enabled = true;
        }
        //iki pas ngeload halamanae
        private void panelControlKaryawan_Paint(object sender, PaintEventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            panel1.Enabled = false;
            simpleButtonUbah.Enabled = false;
            simpleButtonHapus.Enabled = false;
            simpleButtonSimpan.Enabled = false;
            bersihsemua();
        }
        //iki button ndelok data
        private void simpleButtonLihat_Click(object sender, EventArgs e)
        {
            LoadDataKaryawan();
            simpleButtonSimpan.Enabled = false;         
        }
        //aksi pas ngeklik gridview ne
     

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            
            gender = "L";
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "P";
        }

        private void simpleButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "insert into tb_karyawan (nik, nama, jk, no_hp, alamat, status) values('"+textEditNIK.Text+"','"+textEditNama.Text+"','"+gender+"','"+textEditNoHP.Text+"','"+textBoxAlamat.Text+"','"+status+"')";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihsemua();
                LoadDataKaryawan();
                simpleButtonSimpan.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string status;
        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            status = "user";
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            status = "admin";
        }

        private void simpleButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                query = "update tb_karyawan set nama = '" + textEditNama.Text + "', jk = '" + gender + "', no_hp = '" + textEditNoHP.Text + "', alamat = '" + textBoxAlamat.Text + "', status = '" + status + "' where nik = '" + textEditNIK.Text + "';";
                koneksi = new SqlConnection(koneksiString);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                koneksi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihsemua();
                LoadDataKaryawan();
                
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
                    query = "delete tb_karyawan where nik = '" + textEditNIK.Text + "'";
                    koneksi = new SqlConnection(koneksiString);

                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihsemua();
                    LoadDataKaryawan();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
           
            textEditNIK.Enabled = false;
            panel1.Enabled = true;
            simpleButtonUbah.Enabled = true;
            simpleButtonHapus.Enabled = true;
        }
    }
}
