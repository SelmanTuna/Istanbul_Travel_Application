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
    public partial class FrmFotograf : Form
    {
        public FrmFotograf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
