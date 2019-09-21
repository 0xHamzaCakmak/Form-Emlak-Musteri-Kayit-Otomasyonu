namespace Emlak_Kayıt_Otomasyonu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxsite = new System.Windows.Forms.ComboBox();
            this.comboBoxsatkira = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxodasay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmetre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxadsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxtelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxnotlar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxblok = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.BtnZambak = new System.Windows.Forms.Button();
            this.BtnGul = new System.Windows.Forms.Button();
            this.BtnMenekse = new System.Windows.Forms.Button();
            this.BtnPapatya = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGoruntule = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnDüzelt = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gayrimenkul Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site:";
            // 
            // comboBoxsite
            // 
            this.comboBoxsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxsite.FormattingEnabled = true;
            this.comboBoxsite.Items.AddRange(new object[] {
            "Zambak Sitesi",
            "Papatya Sitesi",
            "Gül Sitesi",
            "Menekşe Sitesi"});
            this.comboBoxsite.Location = new System.Drawing.Point(142, 60);
            this.comboBoxsite.Name = "comboBoxsite";
            this.comboBoxsite.Size = new System.Drawing.Size(185, 24);
            this.comboBoxsite.TabIndex = 2;
            this.comboBoxsite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBoxsatkira
            // 
            this.comboBoxsatkira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxsatkira.FormattingEnabled = true;
            this.comboBoxsatkira.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.comboBoxsatkira.Location = new System.Drawing.Point(142, 104);
            this.comboBoxsatkira.Name = "comboBoxsatkira";
            this.comboBoxsatkira.Size = new System.Drawing.Size(185, 24);
            this.comboBoxsatkira.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat / Kira :";
            // 
            // comboBoxodasay
            // 
            this.comboBoxodasay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxodasay.FormattingEnabled = true;
            this.comboBoxodasay.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.comboBoxodasay.Location = new System.Drawing.Point(142, 149);
            this.comboBoxodasay.Name = "comboBoxodasay";
            this.comboBoxodasay.Size = new System.Drawing.Size(185, 24);
            this.comboBoxodasay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "MetreKare :";
            // 
            // textBoxmetre
            // 
            this.textBoxmetre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxmetre.Location = new System.Drawing.Point(142, 191);
            this.textBoxmetre.Name = "textBoxmetre";
            this.textBoxmetre.Size = new System.Drawing.Size(185, 26);
            this.textBoxmetre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat :";
            // 
            // textBoxfiyat
            // 
            this.textBoxfiyat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxfiyat.Location = new System.Drawing.Point(142, 230);
            this.textBoxfiyat.Name = "textBoxfiyat";
            this.textBoxfiyat.Size = new System.Drawing.Size(185, 26);
            this.textBoxfiyat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(451, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // textBoxadsoyad
            // 
            this.textBoxadsoyad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxadsoyad.Location = new System.Drawing.Point(498, 60);
            this.textBoxadsoyad.Name = "textBoxadsoyad";
            this.textBoxadsoyad.Size = new System.Drawing.Size(185, 26);
            this.textBoxadsoyad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(394, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad :";
            // 
            // textBoxtelefon
            // 
            this.textBoxtelefon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxtelefon.Location = new System.Drawing.Point(498, 104);
            this.textBoxtelefon.Name = "textBoxtelefon";
            this.textBoxtelefon.Size = new System.Drawing.Size(185, 26);
            this.textBoxtelefon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(411, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon :";
            // 
            // textBoxnotlar
            // 
            this.textBoxnotlar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxnotlar.Location = new System.Drawing.Point(498, 153);
            this.textBoxnotlar.Multiline = true;
            this.textBoxnotlar.Name = "textBoxnotlar";
            this.textBoxnotlar.Size = new System.Drawing.Size(185, 103);
            this.textBoxnotlar.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(418, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Notlar :";
            // 
            // comboBoxblok
            // 
            this.comboBoxblok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxblok.FormattingEnabled = true;
            this.comboBoxblok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxblok.Location = new System.Drawing.Point(142, 274);
            this.comboBoxblok.Name = "comboBoxblok";
            this.comboBoxblok.Size = new System.Drawing.Size(66, 24);
            this.comboBoxblok.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Blok :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(214, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "No :";
            // 
            // textBoxNo
            // 
            this.textBoxNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNo.Location = new System.Drawing.Point(265, 275);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(62, 26);
            this.textBoxNo.TabIndex = 23;
            // 
            // BtnZambak
            // 
            this.BtnZambak.BackColor = System.Drawing.Color.Gray;
            this.BtnZambak.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnZambak.Location = new System.Drawing.Point(784, 13);
            this.BtnZambak.Name = "BtnZambak";
            this.BtnZambak.Size = new System.Drawing.Size(90, 51);
            this.BtnZambak.TabIndex = 24;
            this.BtnZambak.Text = "ZAMBAK";
            this.BtnZambak.UseVisualStyleBackColor = false;
            // 
            // BtnGul
            // 
            this.BtnGul.BackColor = System.Drawing.Color.Gray;
            this.BtnGul.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGul.Location = new System.Drawing.Point(709, 77);
            this.BtnGul.Name = "BtnGul";
            this.BtnGul.Size = new System.Drawing.Size(75, 51);
            this.BtnGul.TabIndex = 25;
            this.BtnGul.Text = "GÜL";
            this.BtnGul.UseVisualStyleBackColor = false;
            // 
            // BtnMenekse
            // 
            this.BtnMenekse.BackColor = System.Drawing.Color.Gray;
            this.BtnMenekse.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMenekse.Location = new System.Drawing.Point(784, 141);
            this.BtnMenekse.Name = "BtnMenekse";
            this.BtnMenekse.Size = new System.Drawing.Size(90, 51);
            this.BtnMenekse.TabIndex = 26;
            this.BtnMenekse.Text = "MENEKŞE";
            this.BtnMenekse.UseVisualStyleBackColor = false;
            // 
            // BtnPapatya
            // 
            this.BtnPapatya.BackColor = System.Drawing.Color.Gray;
            this.BtnPapatya.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPapatya.Location = new System.Drawing.Point(875, 77);
            this.BtnPapatya.Name = "BtnPapatya";
            this.BtnPapatya.Size = new System.Drawing.Size(86, 51);
            this.BtnPapatya.TabIndex = 27;
            this.BtnPapatya.Text = "PAPATYA";
            this.BtnPapatya.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(808, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Site";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 334);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 205);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Site";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Metre";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Blok";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No";
            this.columnHeader7.Width = 52;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ad Soyad";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telofon";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Notlar";
            this.columnHeader10.Width = 104;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sat Kira";
            // 
            // BtnGoruntule
            // 
            this.BtnGoruntule.Location = new System.Drawing.Point(368, 285);
            this.BtnGoruntule.Name = "BtnGoruntule";
            this.BtnGoruntule.Size = new System.Drawing.Size(104, 33);
            this.BtnGoruntule.TabIndex = 30;
            this.BtnGoruntule.Text = "Görüntüle";
            this.BtnGoruntule.UseVisualStyleBackColor = true;
            this.BtnGoruntule.Click += new System.EventHandler(this.BtnGoruntule_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(478, 285);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(104, 33);
            this.BtnKaydet.TabIndex = 31;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(588, 285);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(104, 33);
            this.BtnSil.TabIndex = 32;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnDüzelt
            // 
            this.BtnDüzelt.Location = new System.Drawing.Point(698, 285);
            this.BtnDüzelt.Name = "BtnDüzelt";
            this.BtnDüzelt.Size = new System.Drawing.Size(104, 33);
            this.BtnDüzelt.TabIndex = 33;
            this.BtnDüzelt.Text = "Düzelt";
            this.BtnDüzelt.UseVisualStyleBackColor = true;
            this.BtnDüzelt.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxid.Location = new System.Drawing.Point(142, 32);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(185, 26);
            this.textBoxid.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(66, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Id :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 542);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnDüzelt);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnPapatya);
            this.Controls.Add(this.BtnMenekse);
            this.Controls.Add(this.BtnGul);
            this.Controls.Add(this.BtnZambak);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxblok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxnotlar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxtelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxadsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxfiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxmetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxodasay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxsatkira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxsite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Gayrimenkul Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxsite;
        private System.Windows.Forms.ComboBox comboBoxsatkira;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxodasay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxmetre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxadsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxtelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxnotlar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxblok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.Button BtnZambak;
        private System.Windows.Forms.Button BtnGul;
        private System.Windows.Forms.Button BtnMenekse;
        private System.Windows.Forms.Button BtnPapatya;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnGoruntule;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnDüzelt;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label14;
    }
}