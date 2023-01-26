// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Reflection.Metadata;


string tekrar = "E";
while (tekrar == "E")
{
    
    Console.Clear();
    Console.WriteLine("Hesap makinesine hoşgeldiniz, lütfen sayı giriniz ");
    var sayi1 = Console.ReadLine();
    double option;
    int opsiyon;
    while (!double.TryParse(sayi1, out option))
    {
        Console.WriteLine("Hata! Lütfen sayı giriniz.");
        sayi1 = Console.ReadLine();
    }
    Console.WriteLine("Lütfen ikinci sayıyı giriniz");
    var sayi2 = Console.ReadLine();
    while (!double.TryParse(sayi2, out option))
    {
        Console.WriteLine("Hata! Lütfen sayı giriniz.");
        sayi2 = Console.ReadLine();
        
    }
    double rakam1 = Convert.ToDouble(sayi1);
    double rakam2 = Convert.ToDouble(sayi2);

    
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
    Console.WriteLine("Ekleme için: 1");
    Console.WriteLine("Çıkartma için: 2");
    Console.WriteLine("Çarpma için: 3");
    Console.WriteLine("Bölme için: 4");
    var islem = Console.ReadLine();

    //while (!int.TryParse(islem, out opsiyon))
    //{
    //        Console.WriteLine("Hatalı Giriş! Lütfen yapmak istediğiniz işlemi seçiniz:");
    //        Console.WriteLine("Ekleme için: 1");
    //        Console.WriteLine("Çıkartma için: 2");
    //        Console.WriteLine("Çarpma için: 3");
    //        Console.WriteLine("Bölme için: 4");
    //        islem = Console.ReadLine();

    //}

        switch (islem)
        {
            case "1":
                Console.WriteLine(sayi1 + " ile " + sayi2 + " toplandığında sonuç = " + (rakam1 + rakam2));
                break;
            case "2":
                Console.WriteLine(sayi1 + " ile " + sayi2 + " çıkartıldığında sonuç = " + (rakam1 - rakam2));
                break;
            case "3":
                Console.WriteLine(sayi1 + " ile " + sayi2 + " çarpıldığında sonuç = " + (rakam1 * rakam2));
                break;
            case "4":
                Console.WriteLine(sayi1 + " ile " + sayi2 + " bölündüğünde sonuç = " + (rakam1 / rakam2));
            break;
        default:
            Console.WriteLine("Hatalı seçim yaptınız.");
            break;

    }


    Console.WriteLine("Baştan başlamak ister misiniz? E/H ");
    tekrar = Console.ReadLine();

    if (tekrar != "E")
    {
        Environment.Exit(0);

    }
}


    




