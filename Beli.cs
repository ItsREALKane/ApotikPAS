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

namespace ApotikPAS
{
    public partial class Beli : Form
    {
        public Beli()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3QJQCSQ;Initial Catalog=apotek;Integrated Security=True");

        private void Beli_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int total = 0;
            int end = 0;

            switch (cmbItem.SelectedItem)
            {
                case "Paracetamol":
                    total = 10000 * (int)numericBanyak.Value;
                    break;

                case "Ibuprofen":
                    total = 10000 * (int)numericBanyak.Value;
                    break;

                case "Amoxicillin":
                    total = 12000 * (int)numericBanyak.Value;
                    break;

                case "Ciprofloxacin":
                    total = 120000 * (int)numericBanyak.Value;
                    break;

                case "Omeprazole":
                    total = 8000 * (int)numericBanyak.Value;
                    break;

                case "Loperamide":
                    total = 5000 * (int)numericBanyak.Value;
                    break;

                case "Cetirizine":
                    total = 11000 * (int)numericBanyak.Value;
                    break;
            }

            end = total;
            string sex = "";

            if (radioCowo.Checked)
            {
                sex = "Cowo";
            }
            else if (radioCewe.Checked)
            {
                sex = "Cewe";
            }

            labeltotal.Text = ("Rp." + end);

            SqlCommand cmd2 = new SqlCommand("Insert into beli5(noid, namapembeli, alamat, produk, banyak, total, gender, date) Values(@noid, @namapembeli, @alamat, @produk, @banyak, @total, @gender, @date)", conn);
            cmd2.Parameters.AddWithValue("noid", txtID.Text);
            cmd2.Parameters.AddWithValue("namapembeli", txtPembeli.Text);
            cmd2.Parameters.AddWithValue("alamat", txtAlamat.Text);
            cmd2.Parameters.AddWithValue("produk", cmbItem.Text);
            cmd2.Parameters.AddWithValue("banyak", numericBanyak.Value);
            cmd2.Parameters.AddWithValue("total", end);
            cmd2.Parameters.AddWithValue("gender", sex);
            cmd2.Parameters.AddWithValue("date", DateTime.Now);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPembeli.Clear();
            txtAlamat.Clear();
            cmbItem.Text = null;
            numericBanyak.Value = 0;
            labeltotal.Text = "Rp.0";
            radioCewe.Checked = false;
            radioCowo.Checked = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin Menghapus data?", "Konfirmasi Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                SqlCommand cmd4 = new SqlCommand("Delete from beli5 where noid=@noid", conn);
                cmd4.Parameters.AddWithValue("noid", txtID.Text);
                conn.Open();
                cmd4.ExecuteNonQuery();
                conn.Close();
                bind_data();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin Update data?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sex = "";

                if (radioCowo.Checked)
                {
                    sex = "Cowo";
                }
                else if (radioCewe.Checked)
                {
                    sex = "Cewe";
                }

                int total = 0;
                switch (cmbItem.SelectedItem.ToString())
                {
                    case "Paracetamol":
                        total = 10000 * (int)numericBanyak.Value;
                        break;

                    case "Ibuprofen":
                        total = 10000 * (int)numericBanyak.Value;
                        break;

                    case "Amoxicillin":
                        total = 12000 * (int)numericBanyak.Value;
                        break;

                    case "Ciprofloxacin":
                        total = 120000 * (int)numericBanyak.Value;
                        break;

                    case "Omeprazole":
                        total = 8000 * (int)numericBanyak.Value;
                        break;

                    case "Loperamide":
                        total = 5000 * (int)numericBanyak.Value;
                        break;

                    case "Cetirizine":
                        total = 11000 * (int)numericBanyak.Value;
                        break;
                }

                labeltotal.Text = ("Rp." + total);

                SqlCommand cmd3 = new SqlCommand("Update beli5 Set namapembeli=@namapembeli, alamat=@alamat, produk=@produk, banyak=@banyak, total=@total, gender=@gender, date=@date where noid=@noid", conn);
                cmd3.Parameters.AddWithValue("namapembeli", txtPembeli.Text);
                cmd3.Parameters.AddWithValue("alamat", txtAlamat.Text);
                cmd3.Parameters.AddWithValue("produk", cmbItem.Text);
                cmd3.Parameters.AddWithValue("banyak", numericBanyak.Value);
                cmd3.Parameters.AddWithValue("total", total);
                cmd3.Parameters.AddWithValue("gender", sex);
                cmd3.Parameters.AddWithValue("date", DateTime.Now);
                cmd3.Parameters.AddWithValue("noid", txtID.Text);

                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                bind_data();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtID.Text = selectedrow.Cells[0].Value.ToString();
            txtPembeli.Text = selectedrow.Cells[1].Value.ToString();
            txtAlamat.Text = selectedrow.Cells[2].Value.ToString();
            cmbItem.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kamu sudah di tab pembelian!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {
            dashboard histori = new dashboard();
            histori.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar aplikasi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericBanyak_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
