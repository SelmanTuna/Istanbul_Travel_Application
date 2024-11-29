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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camibilgi=new FrmCamiler();
            camibilgi.Show();
        


        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmHarita frmharita = new FrmHarita();
            frmharita.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmKamera frmkamera = new FrmKamera();
            frmkamera.Show();
            


        }
        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro frmmetro = new FrmMetro();
            frmmetro.Show();
          

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobüs metrobüsform = new FrmMetrobüs();
            metrobüsform.Show();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNeAlınır nealınırform = new FrmNeAlınır();
            nealınırform.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNeYenir neyenirformu = new FrmNeYenir();
            neyenirformu.Show();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKöprüler formköprü = new FrmKöprüler();
            formköprü.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMuzeler frmmuze = new FrmMuzeler();
            frmmuze.Show();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKorular koruformu = new FrmKorular();
            koruformu.Show();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCarsılar carsıformu = new FrmCarsılar();
            carsıformu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAvm formavm = new FrmAvm();
            formavm.Show();
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAdalar adaform = new FrmAdalar();
            adaform.Show();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmFotograf frmfoto = new FrmFotograf();
            frmfoto.Show();
           

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini İstanbul Programı C# dersleri grubunun çalışması olarak hazırlanmıştır.E-İstanbul Şehir Rehberi niteliğindedir.10 Mart 2022.");
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\sumey\\Downloads\\Fon-Muzikleri-Fikrimin-İnce-Gülü.Mp3";
            axWindowsMediaPlayer1.Visible = false;

        }
    }
}
