namespace ApotikPAS
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            btnLogout = new Button();
            label2 = new Label();
            btnHistori = new Button();
            btnBeli = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnCari = new Button();
            txtCari = new TextBox();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 184, 228);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 49);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1129, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Square721 BT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(492, 9);
            label7.Name = "label7";
            label7.Size = new Size(391, 36);
            label7.TabIndex = 6;
            label7.Text = "APOTEK ORANG SEHAT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(92, 184, 228);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnHistori);
            panel2.Controls.Add(btnBeli);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 617);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 487);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 6;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(14, 526);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 79);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOG\r\nOUT\r\n";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 70);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "Kenas Akia";
            // 
            // btnHistori
            // 
            btnHistori.BackColor = Color.White;
            btnHistori.Font = new Font("Square721 BT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistori.Location = new Point(0, 199);
            btnHistori.Name = "btnHistori";
            btnHistori.Size = new Size(129, 55);
            btnHistori.TabIndex = 3;
            btnHistori.Text = "HISTORI";
            btnHistori.UseVisualStyleBackColor = false;
            btnHistori.Click += btnHistori_Click;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.White;
            btnBeli.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeli.Location = new Point(0, 138);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(129, 55);
            btnBeli.TabIndex = 2;
            btnBeli.Text = "PEMBELIAN";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(153, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1003, 392);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(492, 73);
            label1.Name = "label1";
            label1.Size = new Size(394, 41);
            label1.TabIndex = 3;
            label1.Text = "HISTORI PEMBELIAN";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(153, 548);
            button1.Name = "button1";
            button1.Size = new Size(142, 30);
            button1.TabIndex = 4;
            button1.Text = "Print PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.MediumSpringGreen;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCari.Location = new Point(1062, 549);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 5;
            btnCari.Text = "CARI";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(832, 549);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(224, 27);
            txtCari.TabIndex = 6;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gold;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(301, 549);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1191, 666);
            Controls.Add(btnRefresh);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnBeli;
        private DataGridView dataGridView1;
        private Button btnHistori;
        private Label label1;
        private Button btnPrint;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label2;
        private Button btnLogout;
        private Label label7;
        private PictureBox pictureBox2;
        private Button btnCari;
        private TextBox txtCari;
        private Button btnRefresh;
        private Button button2;
    }
}