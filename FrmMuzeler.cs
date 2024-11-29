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
    public partial class FrmMuzeler : Form
    {
        public FrmMuzeler()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "KÜLTÜR VE TURİZM BAKANALIĞI'NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TOPKAPI SARAYI MÜZESİ");
                comboBox2.Items.Add("AYASOFYA MÜZESİ");
                comboBox2.Items.Add("AYA İRİNİ KİLİSESİ MÜZESİ");
                comboBox2.Items.Add("ANADOLUHİSARI MÜZESİ");
                comboBox2.Items.Add("RUMELİHİSARI MÜZESİ");

            }
            if (comboBox1.Text == "İSTANBUL BÜYÜKŞEHİR BELEDİYESİNE BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YEREBATAN SARNICI MÜZESİ");
                comboBox2.Items.Add("PANOROMA 1453 TARİH MÜZESİ");
                comboBox2.Items.Add("ATATÜRK MÜZESİ");
                comboBox2.Items.Add("İTFAİYE MÜZESİ");
                comboBox2.Items.Add("MİNİATÜRK");

            }
            if (comboBox1.Text == "MİLLİ SARAYLARA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AYNALIKAVAK KASRI ");
                comboBox2.Items.Add("BEYKOZ SARAYI");
                comboBox2.Items.Add("BEYLERBEYİ SARAYI");
                comboBox2.Items.Add("DOLMABAHÇE SARAYI");
                comboBox2.Items.Add("FLORYA ATATÜRK DENİZ KÖŞKÜ");
                comboBox2.Items.Add("IHLAMURLAR KASRI");

            }
            if (comboBox1.Text == "GENELKURMAY BAŞKANLIĞI'NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DENİZ MÜZESİ");
                comboBox2.Items.Add("HAVACILIK MÜZESİ");
                comboBox2.Items.Add("ASKERİ MÜZE");
               

            }
            if (comboBox1.Text == "ÖZEL MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İSTANBUL MODERN SANAT MÜZESİ");
                comboBox2.Items.Add("İSTANBUL OYUNCAK  MÜZESİ");
                comboBox2.Items.Add("JURASSIC LAND");
                comboBox2.Items.Add("SİRKECİ GARI TCDD MÜZESİ");
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text== "TOPKAPI SARAYI MÜZESİ")
            {
                richTextBox1.Text = "Topkapı Sarayı (Osmanlı Türkçesi: طوپقپو سرايى), İstanbul Sarayburnu'nda, Osmanlı İmparatorluğu'nun 600 yıllık tarihinin 400 yılı boyunca, devletin idare merkezi olarak kullanılan ve Osmanlı padişahlarının yaşadığı saraydır.[1] Bir zamanlar içinde 4.000'e yakın insan yaşamıştır.Topkapı Sarayı Fatih Sultan Mehmed tarafından 1478’de yaptırılmış, Abdülmecid’in Dolmabahçe Sarayı’nı yaptırmasına kadar yaklaşık 380 sene boyunca devletin idare merkezi ve Osmanlı padişahlarının resmi ikâmetgâhı olmuştur. Kuruluş yıllarında yaklaşık 700.000 m²'lik bir alanda yer alan sarayın bugünkü alanı 80.000 m²'dir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\topkapı müzesi.jpg";
            }
            if(comboBox2.Text== "AYASOFYA MÜZESİ")
            {
                richTextBox1.Text = "Ayasofya (anlamı: Kutsal Bilgelik; Grekçe: Ἁγία Σοφία, romanize: Agia Sofia), eski adıyla Kutsal Bilgelik Kilisesi ve Ayasofya Müzesi veya günümüzdeki resmî adıyla Ayasofya-i Kebîr Câmi-i Şerîfi (Kutsal Büyük Ayasofya Camii)[4][5], İstanbul'da yer alan bir cami ve eski bazilika, katedral ve müzedir. Bizans İmparatoru I. Justinianus tarafından, 532-537 yılları arasında İstanbul'un tarihî yarımadasındaki eski şehir merkezine inşa ettirilmiş bazilika planlı bir patrik katedrali olmuştur. 1453 yılında İstanbul'un Osmanlılar tarafından fethedilmesinden sonra II. Mehmed tarafından camiye dönüştürülmüştür. Mustafa Kemal Atatürk tarafından 1934 yılında yayımlanan Bakanlar Kurulu Kararnamesi ile müzeye dönüştürülmüş, kazı ve tadilat çalışmaları başlatılmış ve 1935'ten 2020'ye kadar müze olarak hizmet vermiştir. 2020 yılında ise müze statüsü iptal edilerek cami statüsü verilmiştir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\ayasofya.jpg";

            }
            if (comboBox2.Text == "AYA İRİNİ KİLİSESİ MÜZESİ")
            {
                richTextBox1.Text = "İstanbul'un bilinen en eski Bizans kilisesi olup ayrıca camiye çevrilmemiş tek Bizans kilisesidir. Eski kaynaklara göre, burada bulunan Roma döneminden kalma Artemis, Afrodit ve Apollon mabetlerinin kalıntılarından yararlanılarak, 4. yüzyılın başlarında I. Konstantin (324-337) zamanında yapılmıştır. Ayasofya'yla aynı avlu duvarı içinde bulunan Aya İrini, 532'deki Nika Ayaklanması sırasında yanındaki Sempson Zenon'la birlikte yanmıştır.İmparator I. Justinianus, Ayasofya'nın yanı sıra Aya İrini'yi de yeniden yaptırmıştır. 532'de yapımına başlanmışsa da bitiş tarihi kesin olarak bilinmemektedir. 8. ve 9. yüzyıllarda yaşanan şiddetli depremler binada önemli hasarlara neden olmuştur. Bizanslıların patrikhane şapeli diye niteledikleri Aya İrini, İstanbul'un fethinden sonra Topkapı Sarayı'nı çevreleyen Sur-ı Sultani içerisinde kalmış, bu yüzden camiye çevrilmediği için önemli bir mimari değişiklik olmamıştır. Önce iç cephane, sonra da Harbiye Nezareti'nin silah ambarı olarak kullanılmıştır. ";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Aya İrini Müzesi.jpg";

            }
            if (comboBox2.Text == "ANADOLUHİSARI MÜZESİ")
            {
                richTextBox1.Text = "Anadolu Hisarı, Anadolu Hisarı Kalesi veya diğer adıyla Güzelce Hisarı, İstanbul'un Beykoz ilçesinin Anadoluhisarı semtinde, Göksu Deresi'nin İstanbul Boğazı'na döküldüğü yerde yer alan bir Osmanlı kalesi.Anadolu hisarı, 7.000 metrekarelik bir alan üzerine, Boğazın en dar noktası olan 660 metre mesafedeki bölgesine 1395 yılında, Yıldırım Bayezid tarafından inşa edilmiştir. Cenevizliler, Bizans'la birlik olup Karadeniz'de (Kefe, Sinop ve Amasra'da) koloniler kurmuşlardı. Bu sebeple, boğaz geçişi Cenevizliler için hayati önem taşımaktaydı. Aynı durum Osmanlılar için de söz konusuydu. Karşı sahilde, İstanbul'un Avrupa yakasında bulunan Rumeli Hisarı ise, 1451-1452 yılları arasında II. Mehmed tarafından, bu yabancı ülkelerin gemilerinin geçişlerini denetim altında tutabilmek amacıyla inşa ettirilmiştir. Fatih Sultan Mehmed, Rumeli Hisarı'nı yaptırırken bu kaleye dış surlar ekletmiştir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\anadolu hisarı.png";

            }
            if (comboBox2.Text == "RUMELİHİSARI MÜZESİ")
            {
                richTextBox1.Text = "Rumeli Hisarı (Boğazkesen Hisarı olarak da bilinir), İstanbul'un Sarıyer ilçesinde, Boğaziçi'nde bulunan ve bulunduğu semte adını veren hisar. Fatih Sultan Mehmet tarafından İstanbul'un Fethi'nden önce, Karadeniz'den gelebilecek saldırıları engellemek amacıyla İstanbul Boğazı'nın en dar (698 m[2]) yerine, Anadolu yakasındaki Anadolu Hisarı'nın tam karşısına inşa ettirilmiştir.Hisar, 30 dönümlük bir alanı kapsamaktadır. Doksan gün gibi kısa bir sürede tamamlanan hisarın üç büyük kulesi, dünyanın en büyük kale burçlarına sahiptir. Rumeli Hisarı'nın adı Fatih vakfiyelerinde Kulle-i Cedide; Neşri tarihinde Yenice Hisar; Kemalpaşazade, Aşıkpaşazade ve Nişancı tarihlerinde Boğazkesen Hisarı olarak geçmektedir.";
                pictureBox2.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Rumeli Hisarı.jpg ";

            }
            if (comboBox2.Text == "YEREBATAN SARNICI MÜZESİ")
            {
                richTextBox1.Text = "Yerebatan Sarnıcı (Bizans Yunancası: βασιλική κινστέρνή; Latince: Basilica Cisterna)[1] İstanbul'da şehrin su ihtiyacını karşılamak üzere 526-527 senelerinde yaptırılmış kapalı su sarnıcı.Ayasofya'nın güneybatısında, Soğukçeşme Sokağı'ndadır. Suyun içinden yükselen pek çok mermer sütun nedeniyle halk arasında Yerebatan Sarayı olarak isimlendirilmektedir. Sarnıcın üzerinde daha önce bir bazilika bulunmasından ötürü, Bazilika Sarnıcı olarak da adlandırılır.Bizans imparatoru I. Justinianus tarafından yaptırılan sarnıç, şehrin birinci ve ikinci tepeleri arasındaki bölgelerin su ihtiyacını karşılayan Hadrianus su yollarına bağlanmıştı. İstanbul'un Osmanlılar tarafından fethinden sonra Sarayburnu ve Bahçe Kapısı civarına su dağıtım merkezi olarak hizmet sundu; Osmanlılar'ın şehirde kendi su tesislerini kurmasından sonra kullanılmasa da merkezinde olduğu mahalleyi temsil eden fiziksel bir simge durumuna geldi; ismi saraya, sadrazamın ahırlarına, caddeye ve mahalleye verildi.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\yerebatan sarnıcı.jpeg";

            }
            if (comboBox2.Text == "PANOROMA 1453 TARİH MÜZESİ")
            {
                richTextBox1.Text = "  Panorama 1453 Tarih Müzesi olarak bilinen İstanbul-Topkapı'da bulunan bu müze, İstanbul'un fethedilişinin çeşitli materyallerle canlandırıldığı panoramik bir müzedir. Topkapı Parkı içerisinde yer almaktadır.31 Ocak 2009 tarihinde açılan müzenin tasarımı ve projelendirmesi 2003'te, uygulama çalışmaları ise 2005 yılında başlamıştır. Müze, 2008 yılında 5 milyon dolarlık bir maliyetle tamamlanmıştır ve aynı zamanda Türkiye'nin ilk panoramik müzesi olma özelliğine sahiptir. Müzenin fikir sahibi ve projenin koordinatörü ressam Haşim Vatandaş'tır.Müzenin panoramik resim çalışmalarına 8 sanatçı tarafından 2005 yılında başlanmış ve 2008 yılında bitirilmiştir. Panoramik olan bu resimde 10.000 figür çizimi yer almaktadır. Resmin surlarındaki yıkılmış kısımlar ve bu bölgelerin büyüklükleri, İstanbul'un ilk belediye başkanı Hızır Bey'e, surların tamiri ile ilgili sunulan rapora göre çizilmiştir.Panoramik resim 38 metre çaplı bir yarım küre üzerine çizilmiştir. Yarım kürenin iç yüzeyini kaplayan resim 2.350 m2, resim ile ziyaretçi platformu arasındaki 3 boyutlu nesnelerin bulunduğu platform 650 m2dir ve ziyaretçiyi her yönden II. Mehmed'in binlerce askerinin tekbir sesleri ve Mehter Marşı kuşatmaktadır. Ayrıca resimde 100 yılı aşkın süre hiç eskimeden kalabilen pigment mürekkep kullanılmıştır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Panoroma Müzesijpg.jpg";

            }
            if (comboBox2.Text == "ATATÜRK MÜZESİ")
            {
                richTextBox1.Text = "Atatürk Evi Müzesi, Atatürk Caddesi üzerinde 1912 yılında inşa edilen iki katlı tarihi bina; kesme, moloz taş ve tuğladan yapılmıştır. 1923 yılında hazine adına tescil edilen ev Vali Konağı olarak kullanılmış, Atatürk'ün Konya'ya gelişlerinde de kendisine tahsis edilmiştir. 1927 yılında hazineden Konya Belediyesi'nce satın alınan ev 19.7.1928 tarihinde Konyalıların Atatürk'e şükranlarının bir ifadesi olarak Atatürk adına tescil edilmiş ve tapusuna Reisicumhur Gazi Mustafa Kemal Paşa'ya Konyalıların hediyesidir. kaydı konulmuştur. 1940 yılında Konya Özel İdaresi'nce sembolik bir bedel karşılığında satın alınan ev, tekrar Vali Konağı haline getirilmiş ve 1963 yılına kadar Vali Konağı olarak kullanılmıştır.1963 yılında bina Millî Eğitim Bakanlığı'na devredilerek onarılmış ve bir yıl sonra 17 Aralık 1964 tarihinde Atatürk Evi-Kültür Müzesi adıyla ziyarete açılmıştır. Atatürk Müzesi, Atatürk'ün doğumunun 100.yılında İl Kutlama Komitesi Başkanlığı'nın talepleri üzerine, Kültür ve Turizm Bakanlığı Eski Eserler ve Müzeler Genel Müdürlüğü'nce restore edilerek, sergileme ve düzenlemesi de yeniden yapılmış ve 17 Nisan 1982 tarihinde Atatürk Müzesi  olarak ziyarete açılmıştır. Müzenin düzenlenmesinde, yapının ev olarak kullanılma özelliği göz önünde tutulmuş olup, bu nedenle mimari özelliğini bozacak bir değişikliğe gidilmemiştir. Müzede Kurtuluş Savaşı'nda Konya ve Konyalının yeri belge ve fotoğraflarla anlatılmaya çalışılmıştır. Müzenin alt ve üst salonlarındaki sergilemede pano ve vitrinle bütünlük sağlanmaya çalışılmış, zemin katta Cumhuriyet öncesine ait belge ve fotoğraflarla Atatürk'ün Konya ziyaretleri anlatılmıştır. Panolarda, Atatürk'ün Konya'ya gelişlerini, şehirde yaptığı ziyaretleri, bu evde tuttuğu günlük notları gösteren belgeler, fotoğraflar ve gazete kupürleri sergilenmektedir. Vitrinlerde ise Atatürk'e ait bazı elbiseler ile bu evde kullandığı muhtelif eşyalar teşhir edilmektedir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\atatürk müzesi.jpeg";

            }
            if (comboBox2.Text == "İTFAİYE MÜZESİ")
            {
                richTextBox1.Text = " Türkiye’nin İlk ve Tek İtfaiye Müzesi olma özelliğini taşıyan “İtfaiye Müzesi” 300 yıllık bir geçmişe sahip olan itfaiye teşkilatında kullanılan malzemelerin bir araya getirilmesi hususu ilk defa 1928 yılında İtfaiye Müdürlüğü bünyesinde gündeme gelmiş ve müze ilk defa 1932 yılında açılmıştır.Müze koleksiyonuna ait olan eserler 29 Mayıs 1996 tarihinde İtfaiye Daire Başkanlığı bünyesinden, Kütüphane ve Müzeler Müdürlüğü’ne devredildikten sonra 1998 yılında “Kont Szechenyı İtfaiye Müzesi” olarak değiştirilmiştir. O dönem Fatih’te hizmet verdiği itfaiye binasının restorasyon aşaması süresinde kapatılan Müze, İtfaiye Müzesi olarak Mayıs 2013 tarihinde ziyaretçilere açılarak İstanbul ili Beşiktaş ilçesi Kılıç Ali Paşa Su Sarnıcındaki yeni yerine taşınarak hizmet vermeye başlamıştır.Dünyadaki en önemli itfaiye müzeleri arasında yer alan müzenin koleksiyonunda mahalle tulumbacılarından günümüz itfaiyecilerine ait dönem kıyafetleri, en eski yangın söndürme araçlarından çeşitli tulumbalar, yangın önleme fıçıları, Bayazıd Kulesi’nde kullanılan işaret sepetleri, telefon santralleri, motorlu yangın söndürme araçları sergilenmektedir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\itfaiye müzesi.jpg";

            }
            if (comboBox2.Text == "MİNİATÜRK")
            {
                richTextBox1.Text = "Miniatürk, Büyük Ülkenin Küçük Bir Modeli sloganıyla yola çıkmış; içerdiği eserler, sunduğu hizmetlerle turistik bir gezinti parkı, minyatür parkı olmuştur.Tarihin farklı çağlarından ve medeniyetlerinden bilinirlik, dönemini temsil ve maketi yapılabilirlik ölçütlerine göre seçilmiş 137 mimari eserin, 1/25 oranında küçültülmüş modelleri yapılmıştır. Bu eserler Hitit, Eski Yunan, Roma, Bizans, Selçuklu, Osmanlı ve Cumhuriyet dönemi mimarisini ve kültürünü temsil eden yapılardır.Miniatürk, sesli rehber sisteminin ilk kez uygulandığı yerdir. Her modelin yanında bulunan bilgilendirme kartları ve mobil uygulama sayesinde ziyaretçiler eser hakkında dokuz dilde (Türkçe, İngilizce, Fransızca, Almanca, İspanyolca, Rusça, Arapça, Farsça, Japonca) bilgi edinebilmektedir.Miniatürk, turistlerin dışında özellikle okulların tercih ettiği bir gezi yeridir. Okullar, Miniatürk'ü kültürel aktivite, kültür gezisi vb. amaçlarla ziyaret etmektedirler. Öğrencilerin Miniatürk'teki ziyaretleri onların eski çağdan günümüze Türk ve dünya kültürünü, sanatını, mimarisini tanımalarına ve öğrenmelerine imkan sağlamaktadır.";
                pictureBox2.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\miniatürk.jpeg";

            }
            if (comboBox2.Text == "AYNALIKAVAK KASRI")
            {
                richTextBox1.Text = "Osmanlı Devleti’nin İstanbul’daki dördüncü büyük sarayı olan Tersane Sarayı, diğer adı ile Aynalıkavak Sahil Sarayı’ndan günümüze ulaşabilen tek yapı, Aynalıkavak Kasrı’dır. Okmeydanı yamaçlarından Haliç kıyılarına doğru uzanan alan, tarihî kaynaklara göre Bizans döneminde imparatorlara ait bir gezinti ve dinlenme yeridir. Fatih Sultan Mehmed’in (1444-1481) İstanbul’u fethinden sonra, Osmanlı sultanlarının da ilgisini çeken bu büyük koruluk, bölgede kurulan Osmanlı tersanesinden dolayı, bahçeleriyle birlikte “Tersane Hasbahçesi” adıyla anılmıştır. Hasbahçe’de bilinen ilk yapı, Kaptan-ı Derya Halil Paşa’nın Sultan I. Ahmed (1603-1617) için 1613 yılı sonlarında yaptırdığı kasırdır. Daha sonraki dönemlerde yeni köşkler, kasırlar ve bunlara ait ilave yapılarla, Tersane Sarayı son şekline kavuşmuştur. Sarayın setler hâlinde yükselen geniş bahçesinde, Haliç’e bakan yeni kasırlardan biri de Sultan III. Ahmed’in (1703-1730) şehzadeleri için düzenlenen sünnet düğününe sahne olan Aynalıkavak Kasrı’dır. Zaman içinde tersanenin büyüyüp genişlemesiyle, saraya ait yapılar birer birer yok olmuştur. 1802-1803 yıllarında tamamen yıkılan saraydan geriye sadece Aynalıkavak Kasrı kalmıştır. “Hasoda Kasrı”, “Hasbahçe Kasrı”, “Daire-i Hümâyûn” gibi adlarla da anılan yapı, bugünkü görünümüne Sultan III. Selim (1789-1807) döneminde kavuşmuş ve Sultan Abdülmecid (1839-1861) döneminde tekrar elden geçirilmiştir. “Lâle Devri” olarak anılan dönemin yaşantısını hatırlatan ve yaklaşık üç yüz yıldır Haliç kıyılarını süsleyen Aynalıkavak Kasrı, 1975 yılında Millî Saraylar yönetimine geçmiş ve 1984’te müze-saray olarak ziyarete açılmıştır. Kasır, kara tarafındaki cephesi tek, deniz tarafındaki cephesi iki katlı düzenlenmiş olarak eğimli zemine uygun bir yerleşim göstermektedir. Çifte dîvanhâne çevresinde gelişen üç sofalı planıyla, 18. yüzyıl Osmanlı saraylarının geleneksel mimari özelliklerini taşımaktadır. Sofaların bir tarafında sultanın önemli konuklarını kabul ettiği Dîvanhâne ile üç oda, diğer tarafında giriş sofası ile iki oda bulunmaktadır. Dış çephede dilimli bir kubbeyle örtülü olduğu görülen Arz Odası’nın tavan eteğinde Sultan III. Selim’in altın yaldızlı tuğrası, pencereler üzerinde Yesârîzâde Efendi’nin ta’lîk hat ile yazdığı, Enderûnî Fâzıl Efendi’nin Aynalıkavak Kasrı’nı öven 54 beyitlik şiiri dikkati çekmektedir. III. Selim’in lirik ve akıcı bestelerini yaptığı sanılan Hasoda’nın pencereleri üzerinde, yine Yesârîzâde’nin ta’lîk hatla yazdığı, Şeyh Galib’in III. Selim’i öven 36 beyitlik şiiri yer almaktadır. Tavanda, Hasoda ile benzer biçimde, geometrik düzen içinde bitkisel ve stilize motiflerle zenginleştirilmiş zarif bir bezeme göze çarpmaktadır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\aynalı kavak kasrı.jpeg";

            }
            if (comboBox2.Text == "BEYKOZ SARAYI")
            {
                richTextBox1.Text = "Osmanlı devrinden kalan ve Dolmabahçe ile Beylerbeyi saraylarından önce yaptırılan Beykoz Mecidiye Kasrı, İstanbul’un eski yapılarındandır.Boğaz’ın Asya kıyısında, Beykoz’da, Hünkâr İskelesi mevkiinde bulunan Beykoz Mecidiye Kasrı, Boğaziçi’nin ilk kâgir ve yeni üslûpta inşa edilmiş yapısıdır.Beykoz Mecidiye Kasrı, Sultan Abdülmecid için Mısır Valisi Kavalalı Mehmed Ali Paşa tarafından 1845 yılında yaptırılmaya başlanmış ve Paşa’nın ölümü üzerine, 1854’te oğlu Said Paşa tarafından tamamlatılarak Padişah’a hediye edilmiştir.Sultan Abdülmecid’e ithafen Mecidiye Kasrı olarak da anılan yapı, denizden başlayarak kat kat setler hâlinde yükselen bir peyzaj düzenlemesine sahip koruparkın tepe noktasında yer almaktadır. Yapıldığı ilk yıllarda Sultan tarafından bir biniş kasrı olarak günlük konaklamalarda, sonraki dönemlerde ise yabancı devlet erkânı ve elçi ağırlamada kullanılmıştır. ";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Beykoz Sarayı.jpg";

            }
            if (comboBox2.Text == "BEYLERBEYİ SARAYI")
            {
                richTextBox1.Text = "Beylerbeyi ve çevresinin yerleşim alanı olarak kullanılması tarihte oldukça gerilere, Bizans dönemine kadar gitmektedir. Farklı tarihsel dönemlerde inşa edilen yapıların ardından Sultan II. Mahmud (1808-1839) döneminde yaptırılan ahşap sarayın yanmasıyla Sultan Abdülaziz, 1863-1865 yılları arasında sarayı ve ek binaları yaptırmıştır. Mâbeyn ve Harem bölümlerinden oluşan saray ana binası ziyarete açıktır. Deniz Köşkleri ile üst set bahçelerle büyük havuzun etrafındaki Sarı Köşk, Mermer Köşk ve saltanat atlarını barındırmak amacıyla inşa edilmiş olan Ahır Köşk ise ziyarete kapalıdır.Beylerbeyi Sarayı yazlık bir saraydır. Özellikle yabancı devlet misafirlerinin ağırlanmasında kullanılmıştır. Avusturya-Macaristan İmparatoru Franz Joseph (1869), Fransız İmparatoriçesi Eugénie (1869), Karadağ Prensi Nikola (1874) ve Alman İmparatoru II. Wilhelm gibi çok sayıda konuk burada ağırlanmıştır. Sultan II. Abdülhamid de tahttan indirildikten sonra hayatının son altı yılını burada geçirmiş ve 1918’de bu sarayda vefat etmiştir.Çeşitli Batı üsluplarının Doğu üsluplarıyla kaynaştırıldığı sarayın iç mimarisi, kullanım özellikleri bakımından Türk evi planına benzemektedir. Bodrumla birlikte üç katlı olarak yapılmış olan sarayda 24 oda, 6 salon yer almaktadır. Taban döşemeleri, Mısır’dan getirtilen hasırlarla kaplıdır. Türk-Hereke yapımı halılar; Fransız Baccarat kristalinden avizeler; İngiliz, Fransız ve İstanbul-Haliç Tersanesi’nde yapılmış saatler ile Çin, Japon, Fransız, Alman ve Türk (Yıldız) porseleni vazolar, sarayın oda ve salonlarının dekorasyonunu tamamlamaktadır. ";
                pictureBox2.ImageLocation = "C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\beylerbeyi sarayı.jpg ";

            }
            if (comboBox2.Text == "DOLMABAHÇE SARAYI")
            {
                richTextBox1.Text = "Dolmabahçe Sarayı’nın bulunduğu bölge, antik çağlardan beri pek çok kez gemilerin sığındığı doğal liman görünümünde bir koy olarak bilinmektedir. Aynı zamanda, 15. yüzyılda Fatih Sultan Mehmed’in İstanbul’u fethi sırasında, Haliç’e indirmek üzere gemilerini karaya çıkardığı yer olduğu da rivayet olunmaktadır. Osmanlı döneminde Kaptan-ı Derya’nın donanma gemilerini demirledikleri ve geleneksel denizcilik törenlerinin yapıldığı bu koy, 17. yüzyıldan itibaren doldurularak “Dolmabahçe” adıyla padişahların hasbahçesi konumuna getirilmiştir. 19. yüzyıla kadar bu hasbahçe içinde yaptırılan ahşap köşk ve kasırlar topluluğu “Beşiktaş Sahil Sarayı” adıyla anılmıştır.Sultan Abdülmecid döneminde (1839-1861), kullanışsız hâle gelen Beşiktaş Sahil Sarayı yıktırılarak yerine Dolmabahçe Sarayı yaptırılmıştır. Dolmabahçe Sarayı’nın inşa sürecini Ebniye-i Hümâyûn kalfalarından (saltanat yapıları kalfaları) Karabet Balyan, Ohannes Serveryan, Nikoğos Balyan ve James William Smith; bina eminliğini 1843-1850 yılları arasında Hacı Said Ağa, bu tarihten 1856’ya kadar ise Esseyyid Ali Şahin Bey yürütmüştür. ";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\dolmabahçe sarayı.jpg";

            }
            if (comboBox2.Text == "FLORYA ATATÜRK DENİZ KÖŞKÜ")
            {
                richTextBox1.Text = "1935 yılında belediye tarafından mimar Seyfi Arkan'a projesi çizdirilmiş; aynı yıl 14 Ağustos günü yapımı tamamlanarak Atatürk'e teslim edilmiştir. Dolmabahçe Sarayı'nda kaldığı dönemlerde sık sık motorla köşke gelen Atatürk, halkla birlikte denize girmiştir. Atatürk, üç yıl boyunca belirli aralıklarla köşkü yazlık çalışma ofisi kullanmış, son ziyaretini ölümünden birkaç ay önce, 28 Mayıs 1938 tarihinde gerçekleştirmiştir. Özellikle 1936 yılının haziran ve temmuz aylarında uzun süre burada konaklamıştır. Köşk önemli davetlere ve bilimsel toplantılara da ev sahipliği yapmıştır. Köşkte ağırlanan tanınmış konuklar arasında İngiltere kralı VIII. Edward ve Windsor düşesi Wallis Simpson da bulunmaktadır. Atatürk'ün ölümünden sonra göreve gelen cumhurbaşkanlarından İsmet İnönü, Celal Bayar, Cemal Gürsel, Cevdet Sunay, Fahri Korutürk ve Kenan Evren de köşkü yazlık olarak kullanmıştır.[1] Daha sonra bölgenin eski ışıltısını yitirmesi ve denizsuyu kalitesinin düşmesi gibi nedenlerle köşk daha az kullanılır hâle gelmiştir. 6 Eylül 1988 tarihinde TBMM Millî Saraylar Daire Başkanlığı'nın yönetimine giren köşk onarılarak müze hâline getirilmiştir. Köşkün kimi bölümleri TBMM mensuplarına hizmet vermesi düşünülerek sosyal tesis olarak ayrılmıştır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Florya Deniz Köşkü.jpeg";

            }
            if (comboBox2.Text == "IHLAMURLAR KASRI")
            {
                richTextBox1.Text = "Ihlamur Kasrı, Beşiktaş ve Nişantaşı arasındaki vadide yer alan Ihlamur Mesiresi'ndeki kasırdır. Buraya Abdülmecit (1839-1861) tarafından Nigoğos Balyan'a “Merasim Köşkü” ile “Maiyet Köşkü” olarak adlandırılan iki kasır yaptırılmıştır. Bunlardan Merasim Köşkü, asıl Ihlamur Kasrı'dır. Yüksek bir subasman üzerine tek kattan oluşan dikdörtgen planlı köşk, kesme taştan inşa edilmiştir.Merasim Köşkü'nün biraz ilerisinde bulunan Maiyet Köşkü daha sade bir yapıdır, iki katı olan bu yapıda, giriş cephesinde iki kollu bir merdiven bulunmaktadır. Girişin ortasında bir hol ve merdivenler ile köşelerde 4 adet oda yer almaktadır.Bugün, çevresinin gürültü ve karmaşasından kendini yüksek duvarlarla koruyan Ihlamur Kasrı çok eskilerden bu yana Ihlamur Mesiresi adıyla anılan bir dinlenme alanının içinde kurulmuş iki yapıdan oluşur. Havuzlu Ihlamur Mahalli, Muhabbet Bahçesi ve Hacı Hüseyin Bağı adlı üç bölümden meydana gelen bu dinlenme alanının, Sultan III. Ahmet döneminde (1703-1730) bir hasbahçeye dönüştürüldüğü, I. Abdülhamit (1774-1789) ve III. Selim (1789-1807) dönemlerindeki düzenlemelerden sonra 19. yüzyılın ilk yarısında Sultan Abdülmecit'in de ilgisini çektiği bilinmektedir. Sultan burada bulunan sade bir bağ evine sık sık gelerek dinlenir, bazı konuklarını, bu arada ünlü Fransız şairi Lamartine'i burada kabul ederek görüşürdü. Daha sonra da bu sade ve küçük kasrın yerine 1849-1855 yılları arasında, bugün bulunanları yaptırdı. Yapılardan biri Merasim Köşkü (törenler için düşünülmüş ve kullanılmıştır.) öbürüyse Maiyet Köşkü (Sultanın maiyeti, kimi zaman da haremi için kullanılmıştır) adlarıyla anılmış, ikisine birden de Ihlamur Kasrı (ya da kasırları) adı verilmiştir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\ıhlamur kasrı.jpg";

            }
            if (comboBox2.Text == "DENİZ MÜZESİ")
            {
                richTextBox1.Text = "İstanbul Deniz Müzesi, Türkiye'nin denizcilik alanında en büyük müzesidir, içerdiği koleksiyon çeşitliliği açısından dünyanın sayılı müzelerinden biridir. Koleksiyonunda yaklaşık 20.000 adet eser bulunmaktadır. Deniz Kuvvetleri Komutanlığı'na bağlı olan İstanbul Deniz Müzesi Türkiye'de kurulan ilk askeri müzedir.İstanbul Deniz Müzesi; 1897 yılında, dönemin Bahriye Nazırı Hasan Hüsnü Paşa'nın emirleri, Miralay (Albay) Hikmet Bey ve Yüzbaşı Süleyman Nutku'nin büyük gayret ve çabaları sonucu Tersane-i Amire'de (Osmanlı Devlet Tersanesi Kasımpaşa, İstanbul'da) küçük bir binada Müze ve Kütüphane İdaresi İsmi ile kurulmuştur.Önceleri düzenlemesi yapılmamış, müze deposu olarak sergiye açılmıştır. 1914 yılında Bahriye Nazırı olan Cemal Paşa, denizciliğin tüm kollarında olduğu gibi müzede de reform yapmış ve müdürlüğe Deniz Yüzbaşı Ressam Ali Sami Boyar'ı getirerek, bilimsel anlamda yeniden düzenlenmesine olanak sağlamıştır. Boyar, Türk gemilerinin tam ve yarım modellerinin yapılması için gemi model atelyesi ve mankenlerin yapıldığı mulaj-manken atelyesini kurarak, müzeciliğin geliştirilmesine ve bugünkü halini almasına temel oluşturmuştur.II. Dünya Savaşı 'nın başlamasıyla, eserler korunma amacıyla Anadolu'ya nakledilmiştir. Savaş sonunda 1946 yılında müzenin tekrar İstanbul'a taşınmasına karar verilmiş ve müze o günün koşullarında en uygun yer olan Dolmabahçe Camii Külliyesi'ne taşınmış, yeni müze müdürü Haluk Şehsuvaroğlu idaresinde iki yıllık bir çalışmadan sonra 27 Eylül 1948 yılında ziyarete açılmıştır. 1961 yılında müze Beşiktaş İskele Meydanı'nda Türk Amirali Kaptan-ı Derya Barbaros Hayreddin Paşa'nın anıtı ve türbesi yanında, bugünkü bulunduğu yere taşınmıştır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\deniz-muzesi.jpg";

            }
            if (comboBox2.Text == "HAVACILIK MÜZESİ")
            {
                richTextBox1.Text = "I. Dünya Savaşı sonunda, en eskisi 1912 yılına ait olmak üzere muhtelif milletlere ait tayyareler ile hangarlarda 1. Dünya Savaşı devamınca Almanlar tarafından yapılan her tip tayyareden bir, iki ve üçer adet bulunması Hava Kuvvetleri Müfettişliği’nce bir hava müzesi kurma kararı alınmasına neden olmuştur. Düşmandan ele geçirilmiş ganimet uçakların da aynı amaçla toplatılmasına başlanmıştır. Ancak müze için toplanan bu uçakların, Kurtuluş Savaşı’nda zarar görmemesi için Kartal Maltepe’ye götürülmesi düşünülmüş, fakat taşıma sırasında uçakların bir kısmı büyük ölçüde hasar görmüştür. Bu hasarlar ile Kurtuluş Savaşı’nda meydana gelen uçak kırımları, hava müzesi kurma fikrini geciktirmiştir.1960 yılında zamanın Hava Kuvvetleri Komutanı Hv.Org. İrfan Tansel'in direktifiyle Türkiye'de Hava Müzesi kurma fikri gündeme gelmiş ve bu amaçla 1963’te yayınlanan bir emirle Hava Kuvvetleri ve diğer birliklerde kullanılan uçaklardan birer adedinin korunması istenmiştir. Sürdürülen çalışmalar sonucu 1966 yılında Hava Müzesi Teşkilatı oluşturulmuş ve 15 Mayıs 1971 yılında İzmir Cumaovası Sivil Havaalanında Türkiye’nin İlk Hava Müzesi açılmıştır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Hava_ve_Uzay_Müzesi_.jpg";

            }
            if (comboBox2.Text == "ASKERİ MÜZE")
            {
                richTextBox1.Text = "Askerî Müze, İstanbul'un Harbiye semtinde Cumhuriyet Caddesi üzerinde bulunan, 54.000 m²lik bir alan üzerinde kurulu 18.600 m²lik binasıyla bir yapılar kompleksidir. Geniş bir alana yayılan Mekteb-i Harbiye binası, Osmanlı Devleti’ne subay yetiştirmek amacıyla kurulmuş ve 1862’de inşa edilmiştir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Askeri_muze_Istanbul.jpg";

            }
            if (comboBox2.Text == "İSTANBUL MODERN SANAT MÜZESİ")
            {
                richTextBox1.Text = "İstanbul Modern Sanat Müzesi veya kısaca İstanbul Modern, İstanbul'un Karaköy semtinde 2004 yılında kurulmuş modern sanat müzesi.Türkiye'nin ilk modern ve çağdaş sanat müzesidir. Mimar Sinan Üniversitesi Güzel Sanatlar Fakültesi ile Tophane-i Amire arasında yer alır. Eczacıbaşı ailesinin öncülüğünde, İstanbul Kültür Sanat Vakfı (İKSV) tarafından kurulan müze, 11 Aralık 2004'te 4 numaralı Antrepo'da ziyarete açıldı[1]. 2018'de bina yeniden yapılması nedeniyle Beyoğlu'nda bir binaya taşındı. 2022'de Beyoğlu'daki lokasyon kapandı ve eski yerinde inşa edilmiş yeni müze binasında tekrar açılacaktır. 2023 yılı Mart ayı itibari ile henüz açılmadı. Müzenin koleksiyonunda modern sanat yapıtları, fotoğraf, tasarım, mimari ve yeni medya alanlarındaki üretimler yer alır.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\istanbul-Modern-Sanat-Muzesi.jpg";

            }
            if (comboBox2.Text == "İSTANBUL OYUNCAK  MÜZESİ")
            {
                richTextBox1.Text = "İstanbul Oyuncak Müzesi, İstanbul'un Göztepe semtinde bulunan ve şair Sunay Akın tarafından 23 Nisan 2005'te kurulan oyuncak müzesidir. Müze koleksiyonu, Sunay Akın’ın 20 yıl boyunca 40'tan fazla ülkede satın aldığı oyuncaklardan oluşturulmuş, dekoruysa sahne tasarım sanatçısı Ayhan Doğan tarafından tasarlanmıştır. Müze içerisinde 1700'lü yıllardan itibaren günümüze kadar gelen oyuncaklar sergilenmektedir. 2012 yılının Kasım ayında dünya çapındaki benzer müzeleri bir araya getirmek için Sunay Akın tarafından kurulmuş olan Oyuncak ve Çocuk Müzeleri Birliği'nin (TOYCO) ilk buluşmasına ev sahipliği yapmış olan müze, Antalya'da, Ataşehir'de ve Gaziantep'te Sunay Akın'ın danışmanlığı ve küratörlüğüyle yeni oyuncak müzeleri açılması için örnek teşkil etmiştir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\oyuncak müzesi.jpeg";

            }
            if (comboBox2.Text == "JURASSIC LAND")
            {
                richTextBox1.Text = "Türkiye’nin tek, Avrupa’nınsa en büyük temalı dinozor parkı olan Jurassic Land, hem büyükler hem de küçüklerin oldukça ilginç ve eğlenceli saatler geçirebilmeleri, milyonlarca yıl öncesine bir zaman yolculuğu yapabilmeleri için Bayrampaşa Forum İstanbul’da ziyaretçilerini ağırlıyor.Oldukça farklı bir konseptte tasarlanan parkın içerisinde müzeden kuluçka ünitelerine, bilim merkezinden oyun alanlarına kadar oldukça ilginç detaylar var. Hem büyükler, hem de küçükler için tasarlanan park, özellikle çocuklu aileler için oldukça eğlenceli saatler geçirilebilecek tema parklardan birisi.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\JURASSICLAND.jpg";

            }
            if (comboBox2.Text == "SİRKECİ GARI TCDD MÜZESİ")
            {
                richTextBox1.Text = "TCDD Sirkeci Garı Demiryolu Müzesi veya İstanbul Demiryolu Müzesi, 23 Eylül 2005'te açılmış bir demiryolu müzesidir. Türkiye Cumhuriyeti Devlet Demiryolları tarafından işletilmektedir.145 metrekarelik alana sahip müzede demiryolu parçaları, uyarı levhaları, ofis gereçleri, plakalar, istasyon saati, istasyon zili, fotoğraflar ve belgeler olmak üzere 300'e yakın eser sergilenmektedir.2006'da 31153'ü yabancı olmak üzere 52774 kişinin müzeyi ziyaret ettiği bildirilmiştir.Müze, pazar ve pazartesi hariç her gün 09.00-17.00 arası açıktır ve tamamen ücretsizdir.";
                pictureBox2.ImageLocation = " C:\\Users\\sumey\\Desktop\\Selman\\Müzeler\\Sirkeci TCDD Müzzesi.jpeg";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
            
        }
    }
}
