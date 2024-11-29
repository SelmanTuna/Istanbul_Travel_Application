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
    public partial class FrmMetrobüs : Form
    {
        public FrmMetrobüs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void FrmMetrobüs_Load(object sender, EventArgs e)
        {
            textBox1.Text = "  Mini İstanbul Programı Metrobüs Hat ve Durakları";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "34AS AVCILAR – SÖĞÜTLÜÇEŞME")
            {
                textBox1.Text = "  Avcılar Kampüs - Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah.- Florya - Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ - Topkapı -Bayrampaşa (Maltepe) - Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy - Zincirlikuyu  ";

            }
            if (comboBox1.Text == "34A CEVİZLİBAĞ - SÖĞÜTLÜÇEŞME")
            {
                textBox1.Text = "  Cevizlibağ - Topkapı - Bayrampaşa Maltepe - Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan - Mecidiyeköy - Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe – Söğütlüçeşme  ";

            }
            if(comboBox1.Text== "34AS AVCILAR – SÖĞÜTLÜÇEŞME ")
            {
                textBox1.Text = "  Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy - Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe –Söğütlüçeşme  ";
            }
            if(comboBox1.Text== " 34BZ BEYLİKDÜZÜ – ZİNCİRLİKUYU")
            {
                textBox1.Text = "  Beylikdüzü Sondurak - Hadımköy - Cumhuriyet Mah.- Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paşa - Cihangir/Üniversite mah. - Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy – Zincirlikuyu ";
            }
            if(comboBox1.Text== "34C BEYLİKDÜZÜ - CEVİZLİBAĞ")
            {
                textBox1.Text = "  Beylikdüzü Sondurak - Hadımköy - Cumhuriyet Mah. - Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paşa - Cihangir/Üniversite mah. - Avcılar Kampüs - Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah.- Florya - Beşyol - Sefaköy - Yenibosna -Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter – Cevizlibağ ";
            }
            if(comboBox1.Text== "34G BEYLİKDÜZÜ - SÖĞÜTLÜÇEŞME")
            {
                textBox1.Text = "  Beylikdüzü Sondurak - Hadımköy - Cumhuriyet Mah.- Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paşa - Cihangir/Üniversite mah. - Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy - Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe –Söğütlüçeşme  ";

            }
            if(comboBox1.Text== "34Z ZİNCİRLİKUYU - SÖĞÜTLÜÇEŞME")
            {
                textBox1.Text = "  Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe - Söğütlüçeşme  ";
            }
        }
    }
}
