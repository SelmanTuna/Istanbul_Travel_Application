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
    public partial class FrmAvm : Form
    {
        public FrmAvm()
        {
            InitializeComponent();
        }
               

        private void FrmAvm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.istanbulcevahir.com/anasayfa");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
           

        }
    }
}
