using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emlak_Kayıt_Otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Siteler;Integrated Security=True");
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from sitebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxsite.Text == "Zambak Sitesi")
            {
                BtnZambak.BackColor = Color.Yellow;
                BtnGul.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Gray;
            }
            if (comboBoxsite.Text == "Papatya Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGul.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Yellow;
            }
            if (comboBoxsite.Text == "Menekşe Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGul.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Yellow;
                BtnPapatya.BackColor = Color.Gray;
            }
            if (comboBoxsite.Text == "Gül Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGul.BackColor = Color.Yellow;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update sitebilgi set id='" + textBoxid.Text.ToString() + "',site='" + comboBoxsite.Text.ToString() + "',oda='" + comboBoxodasay.Text.ToString() + "',metre='" + textBoxmetre.Text.ToString() + "',fiyat='" + textBoxfiyat.Text.ToString() + "',blok='" + comboBoxblok.Text.ToString() + "',no='" + textBoxNo.Text.ToString() + "',adsoyad='" + textBoxadsoyad.Text.ToString() + "',telefon='" + textBoxtelefon.Text.ToString() + "',notlar='" + textBoxnotlar.Text.ToString() + "',satkira='" + comboBoxsatkira.Text.ToString() + "' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

        private void BtnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi (id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBoxid.Text.ToString() + "','" + comboBoxsite.Text.ToString() + "','" + comboBoxodasay.Text.ToString() + "','" + textBoxmetre.Text.ToString() + "','" + textBoxfiyat.Text.ToString() + "','" + comboBoxblok.Text.ToString() + "','" + textBoxNo.Text.ToString() + "','" + textBoxadsoyad.Text.ToString() + "','" + textBoxtelefon.Text.ToString() + "','" + textBoxnotlar.Text.ToString() + "','" + comboBoxsatkira.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }
        int id = 0;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from sitebilgi where id=('" + id + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBoxsite.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxodasay.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxmetre.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxfiyat.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBoxblok.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBoxadsoyad.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBoxtelefon.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBoxnotlar.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBoxsatkira.Text = listView1.SelectedItems[0].SubItems[10].Text;
            

        }
    }
}
