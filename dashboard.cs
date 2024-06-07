using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Security.Cryptography;

namespace ApotikPAS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3QJQCSQ;Initial Catalog=apotek;Integrated Security=True");

        private void btnBeli_Click(object sender, EventArgs e)
        {
            Beli beli = new Beli();
            beli.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select noid, namapembeli, alamat, produk, total, banyak, gender, date from beli5", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kamu sudah di tab Histori!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 220, 20);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select noid, namapembeli As namapembeli, alamat As alamat, produk As produk, total As total, gender As gender, date As date,banyak from beli5 where namapembeli Like @namapembeli + '%'", conn);
            cmd1.Parameters.AddWithValue("noid", txtCari.Text);
            cmd1.Parameters.AddWithValue("namapembeli", txtCari.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select noid, namapembeli, alamat, produk, total, banyak, gender, date from beli5", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                        form.Close();
                    }
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
