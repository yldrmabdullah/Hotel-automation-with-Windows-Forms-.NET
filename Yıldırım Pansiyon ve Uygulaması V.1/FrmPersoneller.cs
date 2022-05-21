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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GJV24EVA\\MSSQL;Initial Catalog=YildirimPansiyon;Integrated Security=True");

        private void verileriGoster()
        {
            ListView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personeller", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Personelid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["DogumTarihi"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Maas"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
               

                ListView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }


        int id = 0;

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(ListView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = (ListView1.SelectedItems[0].SubItems[1].Text);
            TxtSoyadi.Text = (ListView1.SelectedItems[0].SubItems[2].Text);
            comboBox1.Text = (ListView1.SelectedItems[0].SubItems[3].Text);
            DtpDogum.Text = (ListView1.SelectedItems[0].SubItems[4].Text);
            TxtTc.Text = (ListView1.SelectedItems[0].SubItems[5].Text);
            TxtMaas.Text = (ListView1.SelectedItems[0].SubItems[6].Text);
            MskTxtTel.Text = (ListView1.SelectedItems[0].SubItems[7].Text);
            TxtMail.Text = (ListView1.SelectedItems[0].SubItems[8].Text);



        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTel.Clear();
            TxtMail.Text = "";
            TxtTc.Clear();
            TxtMaas.Clear();
            DtpDogum.Text = "";


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personeller set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='"
                + MskTxtTel.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTc.Text + "',Maas='" + TxtMaas.Text+ "',DogumTarihi='"
         + DtpDogum.Value.ToString("yyyy-MM-dd") + "' where Personelid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            ListView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personeller where Adi like '%" + textBox2.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Personelid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Maas"].ToString());
                ekle.SubItems.Add(oku["DogumTarihi"].ToString());

                ListView1.Items.Add(ekle);

            }
            baglanti.Close();

        }


        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            id = int.Parse(ListView1.SelectedItems[0].SubItems[0].Text);
            baglanti.Open();
            string sql = "delete from Personeller where Personelid = @id";
            SqlParameter parameter = new SqlParameter("id", id);
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(parameter);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personeller (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,Maas,DogumTarihi) values" +
                "('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTel.Text + "','" + TxtMail.Text + "','" + TxtTc.Text +
                "','" + TxtMaas.Text + "','" + DtpDogum.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Yeni Personel Kaydedildi");
        }
    }
}
