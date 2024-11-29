using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ders_52_İstanbul_Uygulaması1_
{
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\sumey\\Documents\\Camiler.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["sultanahmet"].ToString();

            }
            baglantı.Close();

            pictureBox1.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\sultanahmet camisi.jpeg";

            webBrowser1.Navigate("https://www.google.com/maps/place/Sultanahmet,+Alemdar,+34110+Fatih%2Fİstanbul/@41.0078733,28.9690765,15z/data=!4m15!1m8!3m7!1s0x14cab9bddcd032e9:0x485518afab977da6!2sSultanahmet,+Alemdar,+34110+Fatih%2Fİstanbul!3b1!8m2!3d41.0078742!4d28.9778313!16s%2Fg%2F11hbt4rbh5!3m5!1s0x14cab9bddcd032e9:0x485518afab977da6!8m2!3d41.0078742!4d28.9778313!16s%2Fg%2F11hbt4rbh5");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }

        private void BtnYeniCami_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Yenicami"].ToString();
            }
            baglantı.Close();

            pictureBox1.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\Yeni Cami.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Yeni+Cami/@41.0169862,28.9697707,17z/data=!4m14!1m7!3m6!1s0x14cab9eba0aba48d:0x653381c9eafc239c!2sYeni+Cami!8m2!3d41.0169862!4d28.9719594!16zL20vMGQ1eGd3!3m5!1s0x14cab9eba0aba48d:0x653381c9eafc239c!8m2!3d41.0169862!4d28.9719594!16zL20vMGQ1eGd3");

        }

        private void FrmCamiler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void BtnAyasofya_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Ayasofya"].ToString();

            }
            baglantı.Close();

            pictureBox1.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\ayasofya.jpg ";
            webBrowser1.Navigate(" https://www.google.com/maps/place/Ayasofya+Camii/@41.008583,28.9779863,17z/data=!4m6!3m5!1s0x14cab9be92011c27:0x236e6f6f37444fae!8m2!3d41.008583!4d28.980175!16zL20vMGJyNXE");


        }

        private void BtnOrtakoy_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Ortaköy"].ToString();

            }
            baglantı.Close();

            pictureBox1.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\ortaköy cami.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Büyük+Mecidiye+Camii/@41.0535199,29.0204566,15.26z/data=!4m15!1m8!3m7!1s0x14cab7cb58883451:0x41cdb323256c259c!2zT3J0YWvDtnksIDM0MzQ3IEJlxZ9pa3RhxZ8vxLBzdGFuYnVs!3b1!8m2!3d41.0539703!4d29.0270806!16s%2Fg%2F1vgx2zbw!3m5!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!8m2!3d41.0472151!4d29.0269478!16zL20vMGJwYmJy");

        }

        private void BtnFatıh_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Fatih"].ToString();

            }
            baglantı.Close();

            pictureBox1.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\Fatih Camsi.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Fatih+Camii/@41.0196532,28.9408422,15z/data=!4m10!1m2!2m1!1sfatih+cami!3m6!1s0x14caba21ca2b1031:0xbcb8746d3c867663!8m2!3d41.0196532!4d28.9499187!15sCgpmYXRpaCBjYW1pWgwiCmZhdGloIGNhbWmSAQZtb3NxdWXgAQA!16s%2Fm%2F0hhrzpk");

        }

        private void BtnSuleymaniye_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Süleymaniye"].ToString();
            }
            baglantı.Close();

            pictureBox1.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\Süleymaniye Camisi.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Süleymaniye+Camii/@41.0167564,28.9604247,17.08z/data=!4m6!3m5!1s0x14cab98d3ac01031:0x8accf5042157cfed!8m2!3d41.016047!4d28.9639711!16zL20vMDJxNm1i");

        }

        private void BtnBeyazıt_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["Beyazıt"].ToString();

            }
            baglantı.Close();

            pictureBox1.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Camiler Data\\Beyazıt Camisi.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Beyazıt+Camii/@41.010222,28.9630139,17z/data=!4m14!1m7!3m6!1s0x14cab991d73292a1:0xc5894f505ceb16fa!2sBeyazıt+Camii!8m2!3d41.010222!4d28.9652026!16zL20vMDYwY2xx!3m5!1s0x14cab991d73292a1:0xc5894f505ceb16fa!8m2!3d41.010222!4d28.9652026!16zL20vMDYwY2xx ");

        }
    }
}
