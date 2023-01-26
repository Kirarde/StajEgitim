using Oop2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = " 12345";
musteri1.Adi = "Engin";
musteri1.Soyadi = "Demiroğ";
musteri1.TcNo = "22222222222";
musteri1.Id = 1;

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.VergiNo = "22222222";
musteri2.MusteriNo = "54354";
musteri2.SirketAdi = "Kodlama.io";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Ekle(musteri1);
customerManager.Ekle(musteri2);