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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Disconnected_Environment
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=ALDAYANDAY\\ALDAYANDAY;" + "database=disc_env; User ID=Sa; Password=Unkown007";
        private SqlConnection koneksi;

        private void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (koneksi.State == ConnectionState.Closed) 
            {
                koneksi.Open();
            }

            string str = "SELECT nama_prodi FROM dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            koneksi.Close(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnOpen.Enabled = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO dbo.Prodi (nama_prodi) VALUES (@namaProdi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@namaProdi", SqlDbType.VarChar, 255).Value = nmProdi;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1_Click(sender, e); 
                    refreshform();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                    {
                        MessageBox.Show("ID Prodi sudah ada. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan saat memasukkan data. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    koneksi.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
