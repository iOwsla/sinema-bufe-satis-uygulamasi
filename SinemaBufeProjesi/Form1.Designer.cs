namespace SinemaBufeProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btnHesapla = new Button();
            groupBox1 = new GroupBox();
            txtBilet = new TextBox();
            txtCay = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtSu = new TextBox();
            txtMisir = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            lbUrunler = new ListBox();
            lblToplamTutar = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            btnTemizle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Mısır:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 83);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 1;
            label2.Text = "Su:";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Goldenrod;
            btnHesapla.Location = new Point(121, 275);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(123, 36);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(txtBilet);
            groupBox1.Controls.Add(txtCay);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSu);
            groupBox1.Controls.Add(txtMisir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 317);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // txtBilet
            // 
            txtBilet.Location = new Point(91, 147);
            txtBilet.Name = "txtBilet";
            txtBilet.Size = new Size(164, 29);
            txtBilet.TabIndex = 7;
            // 
            // txtCay
            // 
            txtCay.Location = new Point(91, 112);
            txtCay.Name = "txtCay";
            txtCay.Size = new Size(164, 29);
            txtCay.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 150);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 5;
            label8.Text = "Bilet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 118);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 4;
            label3.Text = "Çay:";
            // 
            // txtSu
            // 
            txtSu.Location = new Point(91, 77);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(164, 29);
            txtSu.TabIndex = 3;
            // 
            // txtMisir
            // 
            txtMisir.Location = new Point(91, 42);
            txtMisir.Name = "txtMisir";
            txtMisir.Size = new Size(164, 29);
            txtMisir.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 5;
            label4.Text = "Bilet: 8₺";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Orange;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(322, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 317);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Tablosu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 48);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 0;
            label5.Text = "Mısır: 4₺";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 83);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 1;
            label6.Text = "Su: 1₺";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 118);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 4;
            label7.Text = "Çay: 2₺";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LimeGreen;
            groupBox3.Controls.Add(btnTemizle);
            groupBox3.Controls.Add(lbUrunler);
            groupBox3.Controls.Add(lblToplamTutar);
            groupBox3.Controls.Add(btnHesapla);
            groupBox3.Location = new Point(550, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 317);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // lbUrunler
            // 
            lbUrunler.FormattingEnabled = true;
            lbUrunler.HorizontalScrollbar = true;
            lbUrunler.ItemHeight = 23;
            lbUrunler.Location = new Point(6, 45);
            lbUrunler.Name = "lbUrunler";
            lbUrunler.Size = new Size(238, 188);
            lbUrunler.TabIndex = 3;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(6, 240);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(169, 23);
            lblToplamTutar.TabIndex = 0;
            lblToplamTutar.Text = "Tolam Tutar: 0.0₺";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 41);
            label10.Name = "label10";
            label10.Size = new Size(321, 43);
            label10.TabIndex = 7;
            label10.Text = "Sinema Büfe Satış Paneli";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.DarkRed;
            btnTemizle.Location = new Point(6, 275);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(109, 36);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(816, 477);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Büfe Sinema";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHesapla;
        private GroupBox groupBox1;
        private TextBox txtBilet;
        private TextBox txtCay;
        private Label label4;
        private Label label3;
        private TextBox txtSu;
        private TextBox txtMisir;
        private GroupBox groupBox2;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Label lblToplamTutar;
        private ListBox lbUrunler;
        private PictureBox pictureBox1;
        private Label label10;
        private Button btnTemizle;
    }
}