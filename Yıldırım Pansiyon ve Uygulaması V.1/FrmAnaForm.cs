using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yıldırım_Pansiyon_ve_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();
            
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            FrmPersoneller fr = new FrmPersoneller();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGelir_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();    
            frm.Show();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar(); 
            frm.Show();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle frm = new FrmRadyoDinle();
            frm.Show();
        }

        private void BtnGazete_Click(object sender, EventArgs e)
        {
            FrmGazeteler frm = new FrmGazeteler();
            frm.Show();
        }

        private void BtnHavaDurumu_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frm = new FrmSifreGuncelle();
            frm.Show();
        }

        private void BtnMusteriMesaj_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
