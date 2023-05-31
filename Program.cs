// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


otobus o1 = new otobus();

o1.id = 1;
o1.firmaAdi = "Kamil Koç";
o1.soforAdi = "Furkan";
o1.soforSoyadi = "AYKAN";
o1.aracPlakasi = "34 KK 34";
o1.otobusYolcuSayisi = 50;
o1.hiz = 81;

otobus o2 = new otobus();
o2.id = 2;
o2.firmaAdi = "Pamukkale Turizm";
o2.soforAdi = "Mehmet";
o2.soforSoyadi = "NACAR";
o2.aracPlakasi = "34 PT 34";
o2.otobusYolcuSayisi = 60;
o2.hiz = 70;

otobus o3 = new otobus();
o3.id = 3;
o3.firmaAdi = "ALİ OSMAN ULUSOY";
o3.soforAdi = "ALİ";
o3.soforSoyadi = "OSMAN";
o3.aracPlakasi = "34 AOU 34";
o3.otobusYolcuSayisi = 49;
o3.hiz = 90;

otobus o4 = new otobus();
o4.id = 4;
o4.firmaAdi = "NİLÜFER TURİZM";
o4.soforAdi = "NİL";
o4.soforSoyadi = "ÜFER";
o4.aracPlakasi = "34 NT 34";
o4.otobusYolcuSayisi = 55;
o4.hiz = 100;



Console.WriteLine(o1.message(o1));
Console.WriteLine(o2.message(o2));
Console.WriteLine(o3.message(o3));
Console.WriteLine(o4.message(o4));





class otobus
{
    public int id;
    public string firmaAdi;
    public string soforAdi;
    public string soforSoyadi;
    public string aracPlakasi;
    public int otobusYolcuSayisi;
    public double hiz;

    //public double maksHiz(double hiz)
    //{
    //    double yeniHiz = ((hiz * 10 / 100) + (hiz));

    //    return yeniHiz;
    //}

    public string message(otobus o1)
    {
        double yeniHiz = ((hiz * 10 / 100) + (hiz));

        if (yeniHiz > 90 && otobusYolcuSayisi >= 51)
        {
            return string.Format(" İD: {0} \n FİRMA ADI: {1} \n ŞÖFÖR AD SOYAD: {2} {3} \n PLAKA : {4} \n MAKSİMUM YOLCU SAYISI :50 \n ARAÇ YOLCU SAYISI: {5} \n YASAL HIZ: 90 \n ARAÇ HIZI: {6} \n YENİ HIZ: {7} \n YOLCU KAPASİTESİNİN ÜZERİNDE YOLCU TAŞIDIĞINIZ VE  YASAL HIZ SINIRININ %10 NU KADARINI GEÇTİĞİNİZ İÇİN CEZAİ İŞLEM UYGULANMIŞTIR.", o1.id, o1.firmaAdi, o1.soforAdi, o1.soforSoyadi, o1.aracPlakasi, o1.otobusYolcuSayisi, o1.hiz, yeniHiz);
        }
        if (otobusYolcuSayisi >= 51)
        {
            return string.Format(" İD: {0} \n FİRMA ADI: {1} \n ŞÖFÖR AD SOYAD: {2} {3} \n PLAKA : {4} \n MAKSİMUM YOLCU SAYISI :50 \n ARAÇ YOLCU SAYISI: {5} \n YASAL HIZ: 90 \n ARAÇ HIZI: {6} \n YENİ HIZ: {7} \n YOLCU KAPASİTESİNİN ÜZERİNDE YOLCU TAŞIDIĞINIZ İÇİN CEZAİ İŞLEM UYGULANMIŞTIR.", o1.id, o1.firmaAdi, o1.soforAdi, o1.soforSoyadi, o1.aracPlakasi, o1.otobusYolcuSayisi, o1.hiz, yeniHiz);
        }
        if (yeniHiz > 90)
        {
            return string.Format(" İD: {0} \n FİRMA ADI: {1} \n ŞÖFÖR AD SOYAD: {2} {3} \n PLAKA : {4} \n MAKSİMUM YOLCU SAYISI :50 \n ARAÇ YOLCU SAYISI: {5} \n YASAL HIZ: 90 \n ARAÇ HIZI: {6} \n YENİ HIZ: {7} \n YASAL HIZ SINIRININ %10 NU KADARINI GEÇTİĞİNİZ İÇİN CEZAİ İŞLEM UYGULANMIŞTIR.", o1.id, o1.firmaAdi, o1.soforAdi, o1.soforSoyadi, o1.aracPlakasi, o1.otobusYolcuSayisi, o1.hiz, yeniHiz);
        }
        else
        {
            return string.Format(" İD: {0} \n FİRMA ADI: {1} \n ŞÖFÖR AD SOYAD: {2} {3} \n PLAKA : {4} \n MAKSİMUM YOLCU SAYISI :50 \n ARAÇ YOLCU SAYISI: {5} \n YASAL HIZ: 90 \n ARAÇ HIZI: {6} \n YENİ HIZ: {7} \n YASAL KURALLARA UYDUĞUNUZ İÇİN TEŞEKKÜR EDER, İYİ YOLCULUKLAR DİLERİZ.", o1.id, o1.firmaAdi, o1.soforAdi, o1.soforSoyadi, o1.aracPlakasi, o1.otobusYolcuSayisi, o1.hiz, yeniHiz);

        }
    }
}