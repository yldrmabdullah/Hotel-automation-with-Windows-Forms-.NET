namespace Yıldırım_Pansiyon_ve_Uygulaması_V._1
{
    partial class FrmGelirGider
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
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.gıda_list = new System.Windows.Forms.ListView();
            this.gida_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icecek_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cerez_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatural_list = new System.Windows.Forms.ListView();
            this.elektrik_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.su_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.internet_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kasa_list = new System.Windows.Forms.ListView();
            this.toplam_tutar_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sonuc_clmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(355, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gıda_list
            // 
            this.gıda_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gida_clmn,
            this.icecek_clmn,
            this.cerez_clmn});
            this.gıda_list.HideSelection = false;
            listViewItem28.Tag = "Gıda";
            listViewItem29.Tag = "İçecek";
            listViewItem30.Tag = "Çerez";
            this.gıda_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this.gıda_list.Location = new System.Drawing.Point(-2, 239);
            this.gıda_list.Name = "gıda_list";
            this.gıda_list.Size = new System.Drawing.Size(239, 325);
            this.gıda_list.TabIndex = 33;
            this.gıda_list.UseCompatibleStateImageBehavior = false;
            this.gıda_list.View = System.Windows.Forms.View.Details;
            // 
            // gida_clmn
            // 
            this.gida_clmn.Text = "Gıda";
            this.gida_clmn.Width = 79;
            // 
            // icecek_clmn
            // 
            this.icecek_clmn.Text = "İçecek";
            this.icecek_clmn.Width = 79;
            // 
            // cerez_clmn
            // 
            this.cerez_clmn.Text = "Çerez";
            this.cerez_clmn.Width = 89;
            // 
            // fatural_list
            // 
            this.fatural_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fatural_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.elektrik_clmn,
            this.su_clmn,
            this.internet_clmn});
            this.fatural_list.HideSelection = false;
            listViewItem31.Tag = "Gıda";
            listViewItem32.Tag = "İçecek";
            listViewItem33.Tag = "Çerez";
            this.fatural_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32,
            listViewItem33});
            this.fatural_list.Location = new System.Drawing.Point(234, 239);
            this.fatural_list.Name = "fatural_list";
            this.fatural_list.Size = new System.Drawing.Size(261, 325);
            this.fatural_list.TabIndex = 34;
            this.fatural_list.UseCompatibleStateImageBehavior = false;
            this.fatural_list.View = System.Windows.Forms.View.Details;
            // 
            // elektrik_clmn
            // 
            this.elektrik_clmn.Text = "Elektrik";
            this.elektrik_clmn.Width = 92;
            // 
            // su_clmn
            // 
            this.su_clmn.Text = "Su";
            this.su_clmn.Width = 79;
            // 
            // internet_clmn
            // 
            this.internet_clmn.Text = "İnternet";
            this.internet_clmn.Width = 89;
            // 
            // kasa_list
            // 
            this.kasa_list.BackColor = System.Drawing.SystemColors.Info;
            this.kasa_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toplam_tutar_clmn,
            this.personel_clmn,
            this.sonuc_clmn});
            this.kasa_list.HideSelection = false;
            listViewItem34.Tag = "Gıda";
            listViewItem35.Tag = "İçecek";
            listViewItem36.Tag = "Çerez";
            this.kasa_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem34,
            listViewItem35,
            listViewItem36});
            this.kasa_list.Location = new System.Drawing.Point(492, 239);
            this.kasa_list.Name = "kasa_list";
            this.kasa_list.Size = new System.Drawing.Size(432, 325);
            this.kasa_list.TabIndex = 35;
            this.kasa_list.UseCompatibleStateImageBehavior = false;
            this.kasa_list.View = System.Windows.Forms.View.Details;
            // 
            // toplam_tutar_clmn
            // 
            this.toplam_tutar_clmn.Text = "Kasadaki Toplam Tutar";
            this.toplam_tutar_clmn.Width = 143;
            // 
            // personel_clmn
            // 
            this.personel_clmn.Text = "Personel Maaşları";
            this.personel_clmn.Width = 136;
            // 
            // sonuc_clmn
            // 
            this.sonuc_clmn.Text = "Sonuç";
            this.sonuc_clmn.Width = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Alınanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(350, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Faturalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(646, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kurum Hesapları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gıda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "İçecek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(161, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Çerez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(255, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Elektrik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(340, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Su";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(410, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "İnternet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(492, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Kasadaki Toplam Tutar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(648, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Personel Maaşları";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(819, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Sonuç";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(923, 563);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasa_list);
            this.Controls.Add(this.fatural_list);
            this.Controls.Add(this.gıda_list);
            this.Controls.Add(this.button1);
            this.Name = "FrmGelirGider";
            this.Text = "Gelir-Gider Tablosu";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView gıda_list;
        private System.Windows.Forms.ColumnHeader gida_clmn;
        private System.Windows.Forms.ColumnHeader icecek_clmn;
        private System.Windows.Forms.ColumnHeader cerez_clmn;
        private System.Windows.Forms.ListView fatural_list;
        private System.Windows.Forms.ColumnHeader elektrik_clmn;
        private System.Windows.Forms.ColumnHeader su_clmn;
        private System.Windows.Forms.ColumnHeader internet_clmn;
        private System.Windows.Forms.ListView kasa_list;
        private System.Windows.Forms.ColumnHeader toplam_tutar_clmn;
        private System.Windows.Forms.ColumnHeader personel_clmn;
        private System.Windows.Forms.ColumnHeader sonuc_clmn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}