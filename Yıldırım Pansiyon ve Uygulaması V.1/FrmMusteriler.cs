using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Yıldırım_Pansiyon_ve_Uygulaması_V._1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GJV24EVA\\MSSQL;Initial Catalog=YildirimPansiyon;Integrated Security=True");
        
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();

        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = (listView1.SelectedItems[0].SubItems[1].Text);
            TxtSoyadi.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            comboBox1.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            MskTxtTel.Text = (listView1.SelectedItems[0].SubItems[4].Text);
            TxtMail.Text = (listView1.SelectedItems[0].SubItems[5].Text);
            TxtTc.Text = (listView1.SelectedItems[0].SubItems[6].Text);
            TxtOdaNo.Text = (listView1.SelectedItems[0].SubItems[7].Text);
            TxtUcret.Text = (listView1.SelectedItems[0].SubItems[8].Text);
            DtpGiris.Text = (listView1.SelectedItems[0].SubItems[9].Text);
            DtpCikis.Text = (listView1.SelectedItems[0].SubItems[10].Text);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
                MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");


            }

            if (TxtOdaNo.Text == "102")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "103")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "104")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "105")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "201")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "202")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "203")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "204")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda204", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "205")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda205", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "301")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "302")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda302", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "303")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda303", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "304")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda304", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "305")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda305", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "401")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda401", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "402")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda402", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "403")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda403", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "404")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda404", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "405")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda405", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "501")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda501", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "502")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda502", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "503")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda503", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "504")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda504", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "505")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda505", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "601")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda601", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "602")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda602", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "603")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda603", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "604")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda604", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }

            if (TxtOdaNo.Text == "605")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda605", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();


            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTel.Clear();
            TxtMail.Text = "";
            TxtTc.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("update MusteriEkle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"
                +MskTxtTel.Text+"',Mail='"+TxtMail.Text+"',TC='"+TxtTc.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"
                +DtpGiris.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+DtpCikis.Value.ToString("yyyy-MM-dd")+"' where Musteriid=" + id +"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");
           
            

           
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();


        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
