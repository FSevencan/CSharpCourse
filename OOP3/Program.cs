
using OOP3;

IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLoggerService());

ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();



List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager};
{
    basvuruManager.KrediOnBilgilendirmesiYap(krediler);
}
