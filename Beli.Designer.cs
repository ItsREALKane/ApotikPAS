namespace ApotikPAS
{
    partial class Beli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beli));
            txtPembeli = new TextBox();
            cmbItem = new ComboBox();
            txtAlamat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            btnCreate = new Button();
            btnClear = new Button();
            numericBanyak = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            btnLogout = new Button();
            label8 = new Label();
            btnHistori = new Button();
            pictureBox2 = new PictureBox();
            btnBeli = new Button();
            panel3 = new Panel();
            label9 = new Label();
            radioCewe = new RadioButton();
            radioCowo = new RadioButton();
            labeltotal = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericBanyak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPembeli
            // 
            txtPembeli.Location = new Point(144, 137);
            txtPembeli.Name = "txtPembeli";
            txtPembeli.PlaceholderText = "Nama pembeli";
            txtPembeli.Size = new Size(373, 27);
            txtPembeli.TabIndex = 0;
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Items.AddRange(new object[] { "", "Paracetamol", "Ibuprofen", "Amoxicillin", "Ciprofloxacin", "Omeprazole", "Loperamide", "Cetirizine" });
            cmbItem.Location = new Point(262, 183);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(255, 28);
            cmbItem.TabIndex = 1;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(581, 88);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.PlaceholderText = "Alamat";
            txtAlamat.Size = new Size(230, 27);
            txtAlamat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(24, 24, 24);
            label1.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 187);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 4;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(24, 24, 24);
            label2.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(144, 235);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 5;
            label2.Text = "Jumlah";
            // 
            // txtID
            // 
            txtID.Location = new Point(144, 88);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID Pembeli";
            txtID.Size = new Size(373, 27);
            txtID.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Lime;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Location = new Point(152, 440);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "BELI";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(452, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // numericBanyak
            // 
            numericBanyak.Location = new Point(262, 232);
            numericBanyak.Name = "numericBanyak";
            numericBanyak.Size = new Size(150, 27);
            numericBanyak.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 475);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1003, 179);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(252, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(352, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 184, 228);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 49);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1129, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Square721 BT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(452, 9);
            label7.Name = "label7";
            label7.Size = new Size(391, 36);
            label7.TabIndex = 0;
            label7.Text = "APOTEK ORANG SEHAT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(92, 184, 228);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnHistori);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnBeli);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 617);
            panel2.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(13, 480);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 21;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(13, 526);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 79);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "LOG\r\nOUT\r\n";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 71);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 19;
            label8.Text = "Kenas Akia";
            // 
            // btnHistori
            // 
            btnHistori.BackColor = Color.White;
            btnHistori.Font = new Font("Square721 BT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistori.Location = new Point(0, 229);
            btnHistori.Name = "btnHistori";
            btnHistori.Size = new Size(129, 55);
            btnHistori.TabIndex = 20;
            btnHistori.Text = "HISTORI";
            btnHistori.UseVisualStyleBackColor = false;
            btnHistori.Click += btnHistori_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.White;
            btnBeli.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeli.Location = new Point(0, 168);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(129, 55);
            btnBeli.TabIndex = 7;
            btnBeli.Text = "PEMBELIAN";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 24, 24);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(radioCewe);
            panel3.Controls.Add(radioCowo);
            panel3.Controls.Add(labeltotal);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(txtPembeli);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnCreate);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtAlamat);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1191, 666);
            panel3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(144, 278);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 20;
            label9.Text = "Jenis Kelamin";
            // 
            // radioCewe
            // 
            radioCewe.AutoSize = true;
            radioCewe.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCewe.ForeColor = Color.White;
            radioCewe.Location = new Point(354, 278);
            radioCewe.Name = "radioCewe";
            radioCewe.Size = new Size(71, 23);
            radioCewe.TabIndex = 19;
            radioCewe.TabStop = true;
            radioCewe.Text = "Cewe";
            radioCewe.UseVisualStyleBackColor = true;
            // 
            // radioCowo
            // 
            radioCowo.AutoSize = true;
            radioCowo.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioCowo.ForeColor = Color.White;
            radioCowo.Location = new Point(277, 278);
            radioCowo.Name = "radioCowo";
            radioCowo.Size = new Size(71, 23);
            radioCowo.TabIndex = 18;
            radioCowo.TabStop = true;
            radioCowo.Text = "Cowo";
            radioCowo.UseVisualStyleBackColor = true;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Font = new Font("Square721 BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labeltotal.ForeColor = Color.White;
            labeltotal.Location = new Point(653, 145);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(0, 19);
            labeltotal.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(581, 144);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 2;
            label6.Text = "Total :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(843, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 191);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(184, 39);
            label5.Name = "label5";
            label5.Size = new Size(103, 160);
            label5.TabIndex = 1;
            label5.Text = "Rp.10.000\r\nRp.10.000\r\nRp.12.000\r\nRp.12.000\r\nRp.8.000\r\nRp.5.000\r\nRp.11.000\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Square721 BT", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 35);
            label4.Name = "label4";
            label4.Size = new Size(127, 160);
            label4.TabIndex = 0;
            label4.Text = "Paracetamol\r\nIbuprofen\r\nAmoxicillin\r\nCiprofloxacin \r\nOmeprazole \r\nLoperamide \r\nCetirizine \r\n\r\n";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(589, 130);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 7;
            // 
            // Beli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 666);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(numericBanyak);
            Controls.Add(cmbItem);
            Controls.Add(panel3);
            Name = "Beli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beli";
            Load += Beli_Load;
            ((System.ComponentModel.ISupportInitialize)numericBanyak).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPembeli;
        private ComboBox cmbItem;
        private TextBox txtAlamat;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Button btnCreate;
        private Button button1;
        private Button btnClear;
        private NumericUpDown numericBanyak;
        private DataGridView dataGridView1;
        private Button btnLogout;
        private Button button3;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnPrint;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnBeli;
        private Button btnHistori;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labeltotal;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label9;
        private RadioButton radioCewe;
        private RadioButton radioCowo;
        private Button button2;
    }
}