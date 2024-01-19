using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _26_Access_Yolcu_Bİlet_bilgileri_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Bilet.mdb");

        //sil
        OleDbCommand komut = new OleDbCommand();
        private void VerileriGöster()
        {
            //her refrehte silinsin kutular
            listView1.Items.Clear();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText="Select * From Bilgiler";
            OleDbDataReader oku = komut.ExecuteReader();

            //veriler okunurken istenilen sütunlara eklenir
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["SeferNo"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());  
                ekle.SubItems.Add(oku["Biniş"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            //göster
            VerileriGöster();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kayıt
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Bilgiler(SeferNo,Tarih,Saat,AdSoyad,Telefon,KoltukNo,Ücret,Cinsiyet,Biniş) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGöster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";


        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox6.Text ="1";
            btn_1.Enabled = false;
            btn_1.BackColor = Color.Green;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "2";
            btn_2.Enabled = false;
            btn_2.BackColor = Color.Green;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "3";
            Btn_3.Enabled = false;
            Btn_3.BackColor = Color.Green;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "4";
            btn_4.Enabled = false;
            btn_4.BackColor = Color.Green;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "5";
            btn_5.Enabled = false;
            btn_5.BackColor = Color.Green;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "6";
            btn_6.Enabled = false;
            btn_6.BackColor = Color.Green;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "7";
            btn_7.Enabled = false;
            btn_7.BackColor = Color.Green;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "8";
            btn_8.Enabled = false;
            btn_8.BackColor = Color.Green;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox6.Text = "9";
            btn_9.Enabled = false;
            btn_9.BackColor = Color.Green;
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "10";
            btn_10.Enabled = false;
            btn_10.BackColor = Color.Green;
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            textBox6.Text = "11";
            btn_11.Enabled = false;
            btn_11.BackColor = Color.Green;
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            textBox6.Text = "12";
            btn_12.Enabled = false;
            btn_12.BackColor = Color.Green;
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            textBox6.Text = "13";
            btn_13.Enabled = false;
            btn_13.BackColor = Color.Green;
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            textBox6.Text = "14";
            btn_14.Enabled = false;
            btn_14.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sil
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Bilgiler where AdSoyad='" + textBox8.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox8.Clear();
            VerileriGöster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //güncelle
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set Seferno='" + textBox1.Text + "',Tarih='" + textBox2.Text + "',Saat='" + textBox3.Text + "',Telefon='" + textBox5.Text + "',KoltukNo='" + textBox6.Text + "',Ücret='" + textBox7.Text + "',Cinsiyet='" + comboBox1.Text + "',Biniş='" + comboBox2.Text + "' where AdSoyad ='" + textBox4.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";

            VerileriGöster();
        }
    }
}
