
namespace _26_Access_Yolcu_Bİlet_bilgileri_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Seferno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KoltukNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ücret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Biniş = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_14 = new System.Windows.Forms.Button();
            this.btn_13 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(37, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verileri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Seferno,
            this.Tarih,
            this.Saat,
            this.AdSoyad,
            this.Telefon,
            this.KoltukNo,
            this.Ücret,
            this.Cinsiyet,
            this.Biniş});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 416);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(950, 242);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Seferno
            // 
            this.Seferno.Text = "Seferno";
            this.Seferno.Width = 73;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tarih.Width = 93;
            // 
            // Saat
            // 
            this.Saat.Text = "Saat";
            this.Saat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Saat.Width = 100;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "AdSoyad";
            this.AdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdSoyad.Width = 100;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 150;
            // 
            // KoltukNo
            // 
            this.KoltukNo.Text = "KoltukNo";
            this.KoltukNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KoltukNo.Width = 100;
            // 
            // Ücret
            // 
            this.Ücret.Text = "Ücret";
            this.Ücret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ücret.Width = 92;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cinsiyet.Width = 145;
            // 
            // Biniş
            // 
            this.Biniş.Text = "Biniş";
            this.Biniş.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Biniş.Width = 89;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(37, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(343, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sefer No:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(431, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(431, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(343, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(431, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(343, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(431, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 26);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(343, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(343, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cinsiyet:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(431, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 26);
            this.textBox7.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(343, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ücret:";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(431, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 26);
            this.textBox6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(343, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Koltuk No:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(431, 189);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 26);
            this.textBox5.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(343, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(343, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Biniş:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(431, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kadıköy",
            "Bostancı",
            "Kartal"});
            this.comboBox2.Location = new System.Drawing.Point(431, 360);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_14);
            this.groupBox1.Controls.Add(this.btn_13);
            this.groupBox1.Controls.Add(this.btn_12);
            this.groupBox1.Controls.Add(this.btn_11);
            this.groupBox1.Controls.Add(this.btn_10);
            this.groupBox1.Controls.Add(this.btn_9);
            this.groupBox1.Controls.Add(this.btn_7);
            this.groupBox1.Controls.Add(this.btn_6);
            this.groupBox1.Controls.Add(this.btn_5);
            this.groupBox1.Controls.Add(this.btn_8);
            this.groupBox1.Controls.Add(this.Btn_3);
            this.groupBox1.Controls.Add(this.btn_4);
            this.groupBox1.Controls.Add(this.btn_2);
            this.groupBox1.Controls.Add(this.btn_1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(636, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 365);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu Düzeni";
            // 
            // btn_14
            // 
            this.btn_14.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_14.Location = new System.Drawing.Point(173, 294);
            this.btn_14.Name = "btn_14";
            this.btn_14.Size = new System.Drawing.Size(71, 49);
            this.btn_14.TabIndex = 12;
            this.btn_14.Text = "14";
            this.btn_14.UseVisualStyleBackColor = true;
            this.btn_14.Click += new System.EventHandler(this.btn_14_Click);
            // 
            // btn_13
            // 
            this.btn_13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_13.Location = new System.Drawing.Point(96, 294);
            this.btn_13.Name = "btn_13";
            this.btn_13.Size = new System.Drawing.Size(71, 49);
            this.btn_13.TabIndex = 11;
            this.btn_13.Text = "13";
            this.btn_13.UseVisualStyleBackColor = true;
            this.btn_13.Click += new System.EventHandler(this.btn_13_Click);
            // 
            // btn_12
            // 
            this.btn_12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_12.Location = new System.Drawing.Point(19, 294);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(71, 49);
            this.btn_12.TabIndex = 10;
            this.btn_12.Text = "12";
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // btn_11
            // 
            this.btn_11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_11.Location = new System.Drawing.Point(173, 231);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(71, 49);
            this.btn_11.TabIndex = 9;
            this.btn_11.Text = "11";
            this.btn_11.UseVisualStyleBackColor = true;
            this.btn_11.Click += new System.EventHandler(this.btn_11_Click);
            // 
            // btn_10
            // 
            this.btn_10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_10.Location = new System.Drawing.Point(96, 231);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(71, 49);
            this.btn_10.TabIndex = 8;
            this.btn_10.Text = "10";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9.Location = new System.Drawing.Point(19, 231);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(71, 49);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_7.Location = new System.Drawing.Point(96, 166);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(71, 49);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_6.Location = new System.Drawing.Point(19, 166);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(71, 49);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_5.Location = new System.Drawing.Point(96, 92);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(71, 49);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(173, 166);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(71, 49);
            this.btn_8.TabIndex = 3;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_3.Location = new System.Drawing.Point(173, 23);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(71, 49);
            this.Btn_3.TabIndex = 2;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_4.Location = new System.Drawing.Point(19, 92);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(71, 49);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_2.Location = new System.Drawing.Point(96, 23);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(71, 49);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_1.Location = new System.Drawing.Point(19, 23);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(71, 49);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(37, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 46);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sil [AdSoyad]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(37, 250);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(189, 26);
            this.textBox8.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(37, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 46);
            this.button4.TabIndex = 25;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(954, 661);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Seferno;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Saat;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader KoltukNo;
        private System.Windows.Forms.ColumnHeader Ücret;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Biniş;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_14;
        private System.Windows.Forms.Button btn_13;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
    }
}

