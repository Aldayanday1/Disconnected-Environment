using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form3 : Form
    {
        private string stringConnection = "data source=ALDAYANDAY\\ALDAYANDAY;database=disc_env;User ID=Sa;Password=Unkown007";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        private string kstr;

        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.customersBindingSource.DataSource = typeof(DataTable);
            this.bnMahasiswa.DataSource = customersBindingSource;
            refreshform();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void FormDataMahasiswa_Load1(object sender, EventArgs e)
        {
            // Perform data retrieval and binding logic here
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.nim, m.nama_mahasiswa, m.alamat, m.jenis_kelamin, m.tgl_lahir, p.nama_prodi FROM dbo.Mahasiswa m JOIN dbo.Prodi p ON m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            customersBindingSource.DataSource = ds.Tables[0];
            txtNIM.DataBindings.Add("Text", customersBindingSource, "nim", true);
            txtNama.DataBindings.Add("Text", customersBindingSource, "nama_mahasiswa", true);
            txtAlamat.DataBindings.Add("Text", customersBindingSource, "alamat", true);
            cbxJenisKelamin.DataBindings.Add("Text", customersBindingSource, "jenis_kelamin", true);
            dtTanggalLahir.DataBindings.Add("Text", customersBindingSource, "tgl_lahir", true);
            cbxProdi.DataBindings.Add("Text", customersBindingSource, "nama_prodi", true);

            koneksi.Close();
        }

        private void cbxProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.Prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxProdi.DisplayMember = "nama_prodi";
            cbxProdi.ValueMember = "id_prodi";
            cbxProdi.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;

            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text;
            nama = txtNama.Text;
            jk = cbxJenisKelamin.Text;
            alamat = txtAlamat.Text;
            tgl = dtTanggalLahir.Value;
            prodi = cbxProdi.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_prodi from dbo.Prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", prodi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_prodi"].ToString());
            }

            dr.Close();
            string str = "insert into dbo.Data_Mahasiswa (nim, nama_mahasiswa, jenis_kelamin, alamat, tgl_lahir, id_prodi)" +
                "values(@NIM, @Nm, @Jk, @Al, @Tgl, @Idp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("Nm", nama));
            cmd.Parameters.Add(new SqlParameter("Jk", jk));
            cmd.Parameters.Add(new SqlParameter("Al", alamat));
            cmd.Parameters.Add(new SqlParameter("Tgl", tgl));
            cmd.Parameters.Add(new SqlParameter("Idp", hs));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasill Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void FormDataMahasiswa_FormClosed1(object sender, FormClosedEventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void refreshform()
        {
            txtNIM.Enabled = false;
            txtNama.Enabled = false;
            cbxJenisKelamin.Enabled = false;
            txtAlamat.Enabled = false;
            dtTanggalLahir.Enabled = false;
            cbxProdi.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormDataMahasiswa_Load1(null, null);
        }

        private void clearBinding()
        {
            txtNIM.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            cbxJenisKelamin.DataBindings.Clear();
            dtTanggalLahir.DataBindings.Clear();
            cbxProdi.DataBindings.Clear();
        }
    }
}
