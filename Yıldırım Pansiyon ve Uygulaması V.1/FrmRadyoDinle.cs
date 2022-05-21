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
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.7:80/;stream.mp3";
        }

        private void FrmRadyoDinle_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";




        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.liderhost.net:8028/;";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.yayin.com.tr:6134/;";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://45.32.154.169:9300/;";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://arabeskmelodi.kesintisizyayin.com:8888/;";

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream.radyoodtu.com.tr/rock;";
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://fenomen.listenfenomen.com/fenomen/128/icecast.audio";
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
        }
    }
}
