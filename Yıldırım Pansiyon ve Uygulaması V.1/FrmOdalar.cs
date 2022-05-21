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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        



        private void BtnOda101_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GJV24EVA\\MSSQL;Initial Catalog=YildirimPansiyon;Integrated Security=True");


        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101",baglanti);  
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if(BtnOda101.Text != "101")
            {
                BtnOda101.BackColor= Color.Red;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda201.Text = oku6["Adi"].ToString() + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda201.Text != "201")
            {
                BtnOda201.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda202.Text = oku7["Adi"].ToString() + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda202.Text != "202")
            {
                BtnOda202.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut8= new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda203.Text = oku8["Adi"].ToString() + oku8["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda203.Text != "203")
            {
                BtnOda203.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda204.Text = oku9["Adi"].ToString() + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda204.Text != "204")
            {
                BtnOda204.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda205", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda205.Text = oku10["Adi"].ToString() + oku10["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda205.Text != "205")
            {
                BtnOda205.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda301.Text = oku11["Adi"].ToString() + oku11["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda301.Text != "301")
            {
                BtnOda301.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda302.Text = oku12["Adi"].ToString() + oku12["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda302.Text != "302")
            {
                BtnOda302.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut13 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku13 = komut13.ExecuteReader();

            while (oku13.Read())
            {
                BtnOda303.Text = oku13["Adi"].ToString() + oku13["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda303.Text != "303")
            {
                BtnOda303.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut14 = new SqlCommand("select * from Oda304", baglanti);
            SqlDataReader oku14 = komut14.ExecuteReader();

            while (oku14.Read())
            {
                BtnOda304.Text = oku14["Adi"].ToString() +" "+ oku14["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda304.Text != "304")
            {
                BtnOda304.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut15 = new SqlCommand("select * from Oda305", baglanti);
            SqlDataReader oku15 = komut15.ExecuteReader();
            
            while (oku15.Read())
            {
                BtnOda305.Text = oku15["Adi"].ToString() + oku15["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda305.Text != "305")
            {
                BtnOda305.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut16 = new SqlCommand("select * from Oda401", baglanti);
            SqlDataReader oku16 = komut16.ExecuteReader();

            while (oku16.Read())
            {
                BtnOda401.Text = oku16["Adi"].ToString() + oku16["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda401.Text != "401")
            {
                BtnOda401.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut17 = new SqlCommand("select * from Oda402", baglanti);
            SqlDataReader oku17 = komut17.ExecuteReader();

            while (oku17.Read())
            {
                BtnOda402.Text = oku17["Adi"].ToString() + oku17["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda402.Text != "402")
            {
                BtnOda402.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut18 = new SqlCommand("select * from Oda403", baglanti);
            SqlDataReader oku18 = komut18.ExecuteReader();

            while (oku18.Read())
            {
                BtnOda403.Text = oku18["Adi"].ToString() + oku18["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda403.Text != "403")
            {
                BtnOda403.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut19 = new SqlCommand("select * from Oda404", baglanti);
            SqlDataReader oku19 = komut19.ExecuteReader();

            while (oku19.Read())
            {
                BtnOda404.Text = oku19["Adi"].ToString() + oku19["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda404.Text != "404")
            {
                BtnOda404.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut20 = new SqlCommand("select * from Oda405", baglanti);
            SqlDataReader oku20 = komut20.ExecuteReader();

            while (oku20.Read())
            {
                BtnOda405.Text = oku20["Adi"].ToString() + oku20["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda405.Text != "405")
            {
                BtnOda405.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select * from Oda501", baglanti);
            SqlDataReader oku21 = komut21.ExecuteReader();

            while (oku21.Read())
            {
                BtnOda501.Text = oku21["Adi"].ToString() + oku21["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda501.Text != "501")
            {
                BtnOda501.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("select * from Oda502", baglanti);
            SqlDataReader oku22 = komut22.ExecuteReader();

            while (oku22.Read())
            {
                BtnOda502.Text = oku22["Adi"].ToString() + oku22["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda502.Text != "502")
            {
                BtnOda502.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("select * from Oda503", baglanti);
            SqlDataReader oku23 = komut23.ExecuteReader();

            while (oku23.Read())
            {
                BtnOda503.Text = oku23["Adi"].ToString() + oku23["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda503.Text != "503")
            {
                BtnOda503.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("select * from Oda504", baglanti);
            SqlDataReader oku24 = komut24.ExecuteReader();

            while (oku24.Read())
            {
                BtnOda504.Text = oku24["Adi"].ToString() + oku24["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda504.Text != "504")
            {
                BtnOda504.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from Oda505", baglanti);
            SqlDataReader oku25 = komut25.ExecuteReader();

            while (oku25.Read())
            {
                BtnOda505.Text = oku25["Adi"].ToString() + oku25["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda505.Text != "505")
            {
                BtnOda505.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut26 = new SqlCommand("select * from Oda601", baglanti);
            SqlDataReader oku26 = komut26.ExecuteReader();

            while (oku26.Read())
            {
                BtnOda601.Text = oku26["Adi"].ToString() + oku26["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda601.Text != "601")
            {
                BtnOda601.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("select * from Oda602", baglanti);
            SqlDataReader oku27 = komut27.ExecuteReader();

            while (oku27.Read())
            {
                BtnOda602.Text = oku27["Adi"].ToString() + oku27["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda602.Text != "602")
            {
                BtnOda602.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("select * from Oda603", baglanti);
            SqlDataReader oku28 = komut28.ExecuteReader();

            while (oku28.Read())
            {
                BtnOda603.Text = oku28["Adi"].ToString() + oku28["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda603.Text != "603")
            {
                BtnOda603.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut29 = new SqlCommand("select * from Oda604", baglanti);
            SqlDataReader oku29 = komut29.ExecuteReader();

            while (oku29.Read())
            {
                BtnOda604.Text = oku29["Adi"].ToString() + oku29["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda604.Text != "604")
            {
                BtnOda604.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut30 = new SqlCommand("select * from Oda605", baglanti);
            SqlDataReader oku30 = komut30.ExecuteReader();

            while (oku30.Read())
            {
                BtnOda605.Text = oku30["Adi"].ToString() + oku30["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda605.Text != "605")
            {
                BtnOda605.BackColor = Color.Red;
            }







        }
    }
}
