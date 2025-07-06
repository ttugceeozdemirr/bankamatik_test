namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
        {
           double bakiye = 2500.0;
           string sifre = "ab18";
           int sifreHak = 3;

            static void Main(string[] args)
            {
                AnaGiris();
            }

            static void AnaGiris()
            {
                Console.Clear();
                Console.WriteLine("=== BANKAMATİK ===");
                Console.WriteLine("1 - Kartlı İşlem");
                Console.WriteLine("2 - Kartsız İşlem");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                    KartliIslem();
                else if (secim == "2")
                    KartsizIslem();
                else if (secim == "0")
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                    BekleVeAnaGiris();
                }
            }

            static void KartliIslem()
            {
                if (sifreHak == 0)
                {
                    Console.WriteLine("Şifre hakkınız bitti. Giriş engellendi.");
                    return;
                }

                Console.Write("Şifre: ");
                string girilen = Console.ReadLine();

                if (girilen == sifre)
                {
                    AnaMenu();
                }
                else
                {
                    sifreHak--;
                    Console.WriteLine($"Hatalı şifre! Kalan hakkınız: {sifreHak}");
                    BekleVeKartliIslem();
                }
            }

            static void AnaMenu()
            {
                Console.Clear();
                Console.WriteLine("=== ANA MENÜ ===");
                Console.WriteLine("1 - Para Çek");
                Console.WriteLine("2 - Para Yatır");
                Console.WriteLine("3 - Bakiye Görüntüle");
                Console.WriteLine("4 - Şifre Değiştir");
                Console.WriteLine("9 - Ana Girişe Dön");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                    ParaCek();
                else if (secim == "2")
                    ParaYatir();
                else if (secim == "3")
                {
                    Console.WriteLine($"Mevcut bakiye: {bakiye} TL");
                    BekleVeAnaMenu();
                }
                else if (secim == "4")
                    SifreDegistir();
                else if (secim == "9")
                    AnaGiris();
                else if (secim == "0")
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                    BekleVeAnaMenu();
                }
            }

            static void ParaCek()
            {
                Console.Write("Çekilecek miktar: ");
                string giris = Console.ReadLine();

                try
                {
                    double miktar = Convert.ToDouble(giris);

                    if (miktar <= 0)
                        Console.WriteLine("Geçersiz miktar!");
                    else if (miktar <= bakiye)
                    {
                        bakiye -= miktar;
                        Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {bakiye} TL");
                    }
                    else
                        Console.WriteLine("Yetersiz bakiye!");
                }
                catch
                {
                    Console.WriteLine("Geçerli bir sayı girin.");
                }

                BekleVeAnaMenu();
            }

            static void ParaYatir()
            {
                Console.Write("Yatırılacak miktar: ");
                string giris = Console.ReadLine();

                try
                {
                    double miktar = Convert.ToDouble(giris);
                    if (miktar > 0)
                    {
                        bakiye += miktar;
                        Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
                    }
                    else
                    {
                        Console.WriteLine("Negatif miktar girilemez.");
                    }
                }
                catch
                {
                    Console.WriteLine("Geçersiz sayı!");
                }

                BekleVeAnaMenu();
            }

            static void SifreDegistir()
            {
                Console.Write("Eski şifre: ");
                string eski = Console.ReadLine();

                if (eski == sifre)
                {
                    Console.Write("Yeni şifre: ");
                    string yeni = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(yeni) && yeni.Length >= 4)
                    {
                        sifre = yeni.Trim();
                        Console.WriteLine("Şifre güncellendi.");
                    }
                    else
                        Console.WriteLine("Yeni şifre geçersiz.");
                }
                else
                    Console.WriteLine("Eski şifre yanlış!");

                BekleVeAnaMenu();
            }

            static void KartsizIslem()
            {
                Console.WriteLine("Kartsız işlem henüz aktif değil.");
                BekleVeAnaGiris();
            }

            static void BekleVeAnaMenu()
            {
                Console.WriteLine("\nAna menüye dönmek için bir tuşa basın...");
                Console.ReadKey();
                AnaMenu();
            }

            static void BekleVeAnaGiris()
            {
                Console.WriteLine("\nAna girişe dönmek için bir tuşa basın...");
                Console.ReadKey();
                AnaGiris();
            }

            static void BekleVeKartliIslem()
            {
                Console.WriteLine("\nTekrar denemek için bir tuşa basın...");
                Console.ReadKey();
                KartliIslem();
            }
        }
    }
    }
}
