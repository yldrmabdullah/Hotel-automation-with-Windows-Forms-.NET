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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GJV24EVA\\MSSQL;Initial Catalog=YildirimPansiyon;Integrated Security=True");
        
        private void veriler()
        {
            listView1.Items.Clear();    
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar ",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text =oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void veriler2()
        {
            listView3.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listView3.Items.Add(ekle);

            }
            baglanti.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,Icecek,Cerezler) values('" + txtGida.Text + "','" + txtİcecek.Text + "','" + txtAtistirma.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
             

            

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values('" + TxtElktrk.Text + "','" + TxtSu.Text + "','" + TxtNet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();

        }
    }
}
