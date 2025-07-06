namespace bankamatik_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BANKAMATİK //

            string sifre = "ab18";
            double bakiye = 2500;
            int hak = 3;

        KARTLI:
            Console.WriteLine("-*-* TUĞÇİŞ BANKA HOŞGELDİNİZ -*-* ");
            Console.WriteLine("Kartlı İşlem - 1\nKartsız İşlem - 2");
            string kartli = Console.ReadLine();

            if (kartli == "1")
            {
                SIFRE:
                if (hak > 0)
                {
                    Console.WriteLine("Şifre Giriniz:");
                    string password = Console.ReadLine();

                    if (sifre == sifre)
                    {
                    ANAMENU:
                        Console.WriteLine("*** ANA MENÜ ***");
                        Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Para Transfer\n4-Eğitim Ödemeleri\n5-Fatura Ödemeleri\n6-Bilgi Güncelle\nSeçiminiz:");
                        string anamenuSecim = Console.ReadLine();

                        if (anamenuSecim == "1")
                        {
                            Console.WriteLine("Çekilecek Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar)
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Paranızı Alınız.");
                                Console.WriteLine("Yeni bakiye:" + bakiye);
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye.\nMevcut Bakiyeniz:" + bakiye + " Çekmek İstenilen Miktar:" + miktar);

                            }

                        }
                        else if (anamenuSecim == "2")
                        {
                            Console.WriteLine ("1-> Kendi hesabıma\n2->Kredi kartına\nSeçiminiz:);
                            string yatirmaSecim
                        }

                        }

                    }

















        }
    }
}
