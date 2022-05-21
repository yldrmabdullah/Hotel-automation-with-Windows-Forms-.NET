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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GJV24EVA\\MSSQL;Initial Catalog=YildirimPansiyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            
          

            int sonuc;
            sonuc = Convert.ToInt32(toplam_tutar_clmn.Text)-(Convert.ToInt32(personel_clmn.Text)+Convert.ToInt32(gida_clmn.Text) + Convert.ToInt32(icecek_clmn.Text) + Convert.ToInt32
                (cerez_clmn.Text) + Convert.ToInt32(elektrik_clmn.Text) + Convert.ToInt32(su_clmn.Text) + Convert.ToInt32(internet_clmn.Text));

            sonuc_clmn.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplam_tutar_clmn.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                gida_clmn.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" Select sum(Icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                icecek_clmn.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                cerez_clmn.Text = oku4["toplam3"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                elektrik_clmn.Text = oku5["toplam4"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                su_clmn.Text = oku6["toplam5"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" Select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                internet_clmn.Text = oku7["toplam6"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand(" Select sum(Maas) as toplam7 from Personeller", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                personel_clmn.Text = oku8["toplam7"].ToString();

            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
