using System.Runtime.InteropServices;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ApotikPAS
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recBtnLogin;
        private Rectangle rectxtPassword;
        private Rectangle recTxtLogin;
        private Rectangle recLabel1;
        private Rectangle recLabel2;
        private Rectangle recImage;
        private Rectangle recBtnLogout;
        private Rectangle recBtnRestart;
        private Rectangle recLblDate;
        private Rectangle recLblTime;
        private Rectangle recButton1;
        private Rectangle recTextbox1;
        private Rectangle recTextbox2;
        private Rectangle recPictureBox1;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nleft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3QJQCSQ;Initial Catalog=apotek;Integrated Security=True; TrustServerCertificate=true");
            con.Open();
            string query = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPw.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                DialogResult result = MessageBox.Show("Login Berhasil!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Beli home = new Beli();
                home.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Login gagal!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah kamu ingin keluar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPw.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}