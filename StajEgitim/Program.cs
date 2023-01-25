// See https://aka.ms/new-console-template for more information
string kategoriEtiket = "Kategoriler";

int ogrenciSayisi = 32000;

double faizOrani = 1.45;

bool sistemGirisYapmisMi = true;

double DolarDun = 7.35;
double DolarBugun = 7.45;
if (DolarDun > DolarBugun)
{
    Console.WriteLine("Dolar Düşmüş");
}
else if (DolarDun < DolarBugun) 
{
    Console.WriteLine("Dolar Artmış");
}
else
{
    Console.WriteLine("Dolar Değişmemiş");
}

if (sistemGirisYapmisMi == true) {
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(kategoriEtiket);