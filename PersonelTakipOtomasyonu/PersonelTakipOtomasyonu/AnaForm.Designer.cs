namespace PersonelTakipOtomasyonu
{
    partial class AnaForm
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
            this.list_personeller = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_gsSoyadı = new System.Windows.Forms.TextBox();
            this.txt_gsAdı = new System.Windows.Forms.TextBox();
            this.txt_gsEmail = new System.Windows.Forms.TextBox();
            this.txt_gsTelno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_perEkle = new System.Windows.Forms.Button();
            this.txt_Eadi = new System.Windows.Forms.TextBox();
            this.txt_Esoyadi = new System.Windows.Forms.TextBox();
            this.txt_EtelNo = new System.Windows.Forms.TextBox();
            this.txt_Eemail = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_testDatGetir = new System.Windows.Forms.Button();
            this.btn_json = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_personeller
            // 
            this.list_personeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.list_personeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_personeller.ItemHeight = 20;
            this.list_personeller.Location = new System.Drawing.Point(0, 36);
            this.list_personeller.Name = "list_personeller";
            this.list_personeller.Size = new System.Drawing.Size(565, 304);
            this.list_personeller.TabIndex = 2;
            this.list_personeller.SelectedIndexChanged += new System.EventHandler(this.list_personeller_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.list_personeller);
            this.panel1.Location = new System.Drawing.Point(26, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 347);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "PERSONELLER LİSTESİ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_gsSoyadı);
            this.panel3.Controls.Add(this.txt_gsAdı);
            this.panel3.Controls.Add(this.txt_gsEmail);
            this.panel3.Controls.Add(this.txt_gsTelno);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.Güncelle);
            this.panel3.Location = new System.Drawing.Point(597, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 275);
            this.panel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "PERSONEL/GUNCELLE/SILME";
            // 
            // txt_gsSoyadı
            // 
            this.txt_gsSoyadı.Location = new System.Drawing.Point(139, 79);
            this.txt_gsSoyadı.Name = "txt_gsSoyadı";
            this.txt_gsSoyadı.Size = new System.Drawing.Size(239, 22);
            this.txt_gsSoyadı.TabIndex = 12;
            // 
            // txt_gsAdı
            // 
            this.txt_gsAdı.Location = new System.Drawing.Point(139, 38);
            this.txt_gsAdı.Name = "txt_gsAdı";
            this.txt_gsAdı.Size = new System.Drawing.Size(239, 22);
            this.txt_gsAdı.TabIndex = 11;
            // 
            // txt_gsEmail
            // 
            this.txt_gsEmail.Location = new System.Drawing.Point(139, 114);
            this.txt_gsEmail.Name = "txt_gsEmail";
            this.txt_gsEmail.Size = new System.Drawing.Size(239, 22);
            this.txt_gsEmail.TabIndex = 10;
            // 
            // txt_gsTelno
            // 
            this.txt_gsTelno.Location = new System.Drawing.Point(139, 151);
            this.txt_gsTelno.Name = "txt_gsTelno";
            this.txt_gsTelno.Size = new System.Drawing.Size(239, 22);
            this.txt_gsTelno.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soyadı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "E-Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Telno";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(139, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Güncelle.Location = new System.Drawing.Point(139, 190);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(239, 35);
            this.Güncelle.TabIndex = 0;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = false;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telno";
            // 
            // btn_perEkle
            // 
            this.btn_perEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_perEkle.Location = new System.Drawing.Point(139, 208);
            this.btn_perEkle.Name = "btn_perEkle";
            this.btn_perEkle.Size = new System.Drawing.Size(239, 34);
            this.btn_perEkle.TabIndex = 4;
            this.btn_perEkle.Text = "KAYIT EKLE";
            this.btn_perEkle.UseVisualStyleBackColor = false;
            this.btn_perEkle.Click += new System.EventHandler(this.btn_perEkle_Click);
            // 
            // txt_Eadi
            // 
            this.txt_Eadi.Location = new System.Drawing.Point(139, 27);
            this.txt_Eadi.Name = "txt_Eadi";
            this.txt_Eadi.Size = new System.Drawing.Size(239, 22);
            this.txt_Eadi.TabIndex = 5;
            // 
            // txt_Esoyadi
            // 
            this.txt_Esoyadi.Location = new System.Drawing.Point(139, 65);
            this.txt_Esoyadi.Name = "txt_Esoyadi";
            this.txt_Esoyadi.Size = new System.Drawing.Size(239, 22);
            this.txt_Esoyadi.TabIndex = 6;
            // 
            // txt_EtelNo
            // 
            this.txt_EtelNo.Location = new System.Drawing.Point(139, 159);
            this.txt_EtelNo.Name = "txt_EtelNo";
            this.txt_EtelNo.Size = new System.Drawing.Size(239, 22);
            this.txt_EtelNo.TabIndex = 7;
            // 
            // txt_Eemail
            // 
            this.txt_Eemail.Location = new System.Drawing.Point(139, 115);
            this.txt_Eemail.Name = "txt_Eemail";
            this.txt_Eemail.Size = new System.Drawing.Size(239, 22);
            this.txt_Eemail.TabIndex = 8;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel2.Controls.Add(this.label11);
            this.Panel2.Controls.Add(this.txt_Eemail);
            this.Panel2.Controls.Add(this.txt_EtelNo);
            this.Panel2.Controls.Add(this.txt_Esoyadi);
            this.Panel2.Controls.Add(this.txt_Eadi);
            this.Panel2.Controls.Add(this.btn_perEkle);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Location = new System.Drawing.Point(597, 51);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(446, 263);
            this.Panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "PERSONEL EKLEME ";
            // 
            // btn_testDatGetir
            // 
            this.btn_testDatGetir.Location = new System.Drawing.Point(68, 577);
            this.btn_testDatGetir.Name = "btn_testDatGetir";
            this.btn_testDatGetir.Size = new System.Drawing.Size(395, 32);
            this.btn_testDatGetir.TabIndex = 4;
            this.btn_testDatGetir.Text = "Test Datalarını Getir";
            this.btn_testDatGetir.UseVisualStyleBackColor = true;
            this.btn_testDatGetir.Click += new System.EventHandler(this.btn_testDatGetir_Click);
            // 
            // btn_json
            // 
            this.btn_json.Location = new System.Drawing.Point(26, 21);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(146, 33);
            this.btn_json.TabIndex = 5;
            this.btn_json.Text = "JSON DATA AKTAR";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "JSON DATA GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(29, 165);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 22);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "SEARCH";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(111, 164);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(253, 22);
            this.tbxSearch.TabIndex = 8;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // cmbFields
            // 
            this.cmbFields.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Email",
            "Phonenumber"});
            this.cmbFields.Location = new System.Drawing.Point(149, 79);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 24);
            this.cmbFields.TabIndex = 0;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1079, 634);
            this.Controls.Add(this.cmbFields);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_json);
            this.Controls.Add(this.btn_testDatGetir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AnaForm";
            this.Text = "Personel Uygulaması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_personeller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.TextBox txt_gsSoyadı;
        private System.Windows.Forms.TextBox txt_gsAdı;
        private System.Windows.Forms.TextBox txt_gsEmail;
        private System.Windows.Forms.TextBox txt_gsTelno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_perEkle;
        private System.Windows.Forms.TextBox txt_Eadi;
        private System.Windows.Forms.TextBox txt_Esoyadi;
        private System.Windows.Forms.TextBox txt_EtelNo;
        private System.Windows.Forms.TextBox txt_Eemail;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_testDatGetir;
        private System.Windows.Forms.Button btn_json;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        public System.Windows.Forms.ComboBox cmbFields;
    }
}