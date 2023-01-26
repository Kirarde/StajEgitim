using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(ihtiyacKrediManager);
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);