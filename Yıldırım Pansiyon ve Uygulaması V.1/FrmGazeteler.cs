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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void FrmGazeteler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.posta.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.oyunlarskor.com");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://edition.cnn.com");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr");
            webBrowser1.ScriptErrorsSuppressed = true;

        }
    }
}
