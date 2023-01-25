// See https://aka.ms/new-console-template for more information
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmen = "Engin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Berkay";
kurs3.IzlenmeOrani = 80;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "c++";
kurs4.Egitmen = "Murat";
kurs4.IzlenmeOrani = 100;

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " %" + kurs.IzlenmeOrani + " tamamlamıştır.");
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}