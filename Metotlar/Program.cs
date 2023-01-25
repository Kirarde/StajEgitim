// See https://aka.ms/new-console-template for more information
using Metotlar;
SepetManager sepetManager = new SepetManager();
Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 60;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    sepetManager.Ekle(urun);
    Console.WriteLine("----------------------------");
}

//sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
