using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_52_İstanbul_Uygulaması1_
{
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/kadikoy-iskelesi/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/taksim/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/uskudar-5/");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/kiz-kulesi/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/pierre-lotti/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/ortakoy/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/emirgan-2/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();

        }

        private void FrmKamera_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

        }
    }
}
