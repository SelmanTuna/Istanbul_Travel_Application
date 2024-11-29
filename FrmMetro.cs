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
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = "  Mini İstanbul Programı Metro Durakları   ";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "M1(Yenikapı - Atatürk Havalimanı) - M1 (Yenikapı - Kirazlı) Metro Hattı")
            {
                textBox1.Text = "  Atatürk Havalimanı,DTM-İstanbul Fuar Merkezi,Yenibosna,Ataköy-Şirinevler,Bahçelievler,Bakırköy-İncirli,Zeytinburnu,Merter,Davutpaşa-YTÜ,Terazidere,Otogar,Kocatepe,Sağmalcılar,Bayrampaşa-Maltepe,Topkapı-Ulubatlı,Emniyet-Fatih,Aksaray,Yenikapı ";

            }
            if (comboBox1.Text == "M2 (Yenikapı - Hacıosman - Sanayi Mahallesi - Seyrantepe) Metro Hattı")
            {
                textBox1.Text = "Yenikapı,Vezneciler-İstanbul Ü.,Haliç,Şişhane,Taksim,Osmanbey,Şişli-Mecidiyeköy,Gayrettepe,Levent,4.Levent,Sanayi Mahallesi,Seyrantepe,İTÜ-Ayazağa,Atatürk Oto Sanayi,Darüşşafaka,Hacıosman";

            }
            if (comboBox1.Text == "M3 (Kirazlı - Başakşehir-Metrokent) Metro Hattı")
            {
                textBox1.Text = " Başakşehir-Metrokent,Başak Konutları,Siteler,Turgut Özal,İkitelli Sanayi,İSTOÇ,Mahmutbey,Yenimahalle,Kirazlı-Bağcılar";
            }
            if (comboBox1.Text == "M4 (Kadıköy - Sabiha Gökçen Havalimanı) Metro Hattı")
            {
                
                textBox1.Text = " Kadıköy,Ayrılık Çeşmesi,Acıbadem,Ünalan,Göztepe,Yenisahra,KozyatağınBostancı,Küçükyalı,Maltepe,Huzurevi,Gülsuyu,Esenkent,Hastane-Adliye,Soğanlık,Kartal,Yakacık-Adnan Kahveci,Pendik,Tavşantepe,Fevzi Çakmak-Hastane,Yayalar-Şeyhli,Kurtköy,Sabiha Gökçen Havalimanı";
            }
            if (comboBox1.Text == "M5 (Üsküdar - Çekmeköy) Metro Hattı")
            {
                textBox1.Text = " Üsküdar,Fıstıkağacı,Bağlarbaşı,Altunizade,Kısıklı,Bulgurlu,Ümraniye,Çarşı,Yamanevler,Çakmak,Ihlamurkuyu,Altınşehir,İmam Hatip Lisesi,Dudullu,Necip Fazıl,Çekmeköy";
            }
            if (comboBox1.Text == "T1 (Kabataş - Bağcılar) Tramvay Hattı")
            {
                textBox1.Text = "Bağcılar,Güneştepe,Yavuzselim,Soğanlı,Akıncılar,Güngören,Merter Tekstil Merkezi,Mehmet Akif,Zeytinburnu,Mithatpaşa,Seyitnizam-Akşemsettin,Merkezefendi,Cevizlibağ-AÖY,Topkapı,Pazartekke,Çapa-Şehremini,Fındıkzade,Haseki,Yusufpaşa,Aksaray,Laleli-İstanbul Ü.,Beyazıt-Kapalıçarşı,Çemberlitaş,Sultanahmet,Gülhane,Sirkeci,Eminönü,Karaköy,Tophane,Fındıklı-Mimar Sinan Ü.,Kabataş ";
            }
            if (comboBox1.Text == "T3 (Kadıköy - Moda) Nostaljik Ring Tramvay Hattı")
            {
                textBox1.Text = " İskele Cami,Çarşı,Altıyol,Bahariye,Kilise,Moda İlkokulu,Moda Caddesi,Rıza Paşa,Mühürdar,Damga Sokak,Kadıköy İDO";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();

        }
    }
}
