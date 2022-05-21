namespace Yıldırım_Pansiyon_ve_Uygulaması_V._1
{
    partial class FrmPersoneller
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnVerileriGoster = new System.Windows.Forms.Button();
            this.DtpDogum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboBox1.Location = new System.Drawing.Point(109, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 28);
            this.comboBox1.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 83;
            this.label10.Text = "Cinsiyet:";
            // 
            // MskTxtTel
            // 
            this.MskTxtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTxtTel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTel.Location = new System.Drawing.Point(491, 161);
            this.MskTxtTel.Mask = "(999) 000-0000";
            this.MskTxtTel.Name = "MskTxtTel";
            this.MskTxtTel.Size = new System.Drawing.Size(199, 27);
            this.MskTxtTel.TabIndex = 77;
            // 
            // TxtMaas
            // 
            this.TxtMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMaas.Location = new System.Drawing.Point(491, 110);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(199, 27);
            this.TxtMaas.TabIndex = 75;
            this.TxtMaas.TextChanged += new System.EventHandler(this.TxtOdaNo_TextChanged);
            // 
            // TxtTc
            // 
            this.TxtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Location = new System.Drawing.Point(491, 65);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(199, 27);
            this.TxtTc.TabIndex = 74;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(492, 206);
            this.TxtMail.MaxLength = 50;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(199, 27);
            this.TxtMail.TabIndex = 73;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(108, 120);
            this.TxtSoyadi.MaxLength = 30;
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(199, 27);
            this.TxtSoyadi.TabIndex = 72;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(108, 68);
            this.TxtAdi.MaxLength = 20;
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(199, 27);
            this.TxtAdi.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Maaşı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "T.C Kimlik Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Adı:";
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(1022, 305);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(177, 48);
            this.BtnAra.TabIndex = 93;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(1022, 230);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(177, 48);
            this.BtnTemizle.TabIndex = 92;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(943, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "İsim:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(1000, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 27);
            this.textBox2.TabIndex = 91;
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(1022, 151);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(177, 48);
            this.BtnSil.TabIndex = 89;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(1022, 75);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(177, 48);
            this.BtnGuncelle.TabIndex = 88;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVerileriGoster.Location = new System.Drawing.Point(1022, 12);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(177, 48);
            this.BtnVerileriGoster.TabIndex = 87;
            this.BtnVerileriGoster.Text = "Verileri Göster";
            this.BtnVerileriGoster.UseVisualStyleBackColor = true;
            this.BtnVerileriGoster.Click += new System.EventHandler(this.BtnVerileriGoster_Click);
            // 
            // DtpDogum
            // 
            this.DtpDogum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDogum.Location = new System.Drawing.Point(109, 213);
            this.DtpDogum.Name = "DtpDogum";
            this.DtpDogum.Size = new System.Drawing.Size(200, 27);
            this.DtpDogum.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 94;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.LightGreen;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ListView1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(1, 457);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(1209, 192);
            this.ListView1.TabIndex = 96;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Tarihi";
            this.columnHeader5.Width = 161;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "T.C";
            this.columnHeader6.Width = 158;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Maaş";
            this.columnHeader7.Width = 162;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Telefon";
            this.columnHeader8.Width = 180;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mail";
            this.columnHeader9.Width = 217;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(303, 284);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 48);
            this.btnEkle.TabIndex = 97;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 648);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.DtpDogum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MskTxtTel);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersoneller";
            this.Text = "Personel Alanı";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskTxtTel;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnVerileriGoster;
        private System.Windows.Forms.DateTimePicker DtpDogum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnEkle;
    }
}