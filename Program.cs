using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bera_odev
{
    internal class Program
    {
        static void Main ( string [ ] args )
        {
        Console.WriteLine ("Tahmin Oyununa Hoşgeldin!");
        Console.WriteLine ("Seviye seç: kolay / orta / zor / uzman");

        string seviye = Console.ReadLine().ToLower();
        int min = 1, max = 100, tahminHakki = 7;

        switch(seviye)
        {
            case "kolay":
            max = 50;
            tahminHakki = 10;
            break;
            case "orta":
            max = 100;
            tahminHakki = 7;
            break;
            case "zor":
            max = 500;
            tahminHakki = 8;
            break;
            case "uzman":
            max = 1000;
            tahminHakki = 10;
            break;
            default:
            Console.WriteLine ("Geçersiz seviye seçildi. Orta seviye başlatılıyor.");
            break;
        }

        Random rnd = new Random();
        int hedefSayi = rnd.Next(min, max + 1);
        int kalanHak = tahminHakki;
        bool bildiMi = false;

        while(kalanHak > 0)
        {
        Console.Write ($"Tahminini gir ({min}-{max}): ");
        string input = Console.ReadLine();

        // Sayı kontrolü
        if(!int.TryParse (input, out int tahmin))
        {
        Console.WriteLine ("Lütfen sadece sayı gir.");
        continue;
        }

        // Tahmin kontrolü
        if(tahmin < min || tahmin > max)
        {
        Console.WriteLine ($"Lütfen {min} ile {max} arasında bir sayı gir.");
        continue;
        }

        if(tahmin == hedefSayi)
        {
        Console.WriteLine ($"Tebrikler! {tahminHakki - kalanHak + 1}. denemede doğru tahmin!");
        bildiMi = true;
        break;
        }
        else if(tahmin < hedefSayi)
        {
        Console.WriteLine ("Daha büyük bir sayı gir.");
        }
        else
        {
        Console.WriteLine ("Daha küçük bir sayı gir.");
        }

        kalanHak--;
        Console.WriteLine ($"Kalan tahmin hakkı: {kalanHak}");
        }

        if(!bildiMi)
        {
        Console.WriteLine ($"Tahmin hakkın bitti. Doğru sayı: {hedefSayi}");
        }

        Console.WriteLine ("Oyun bitti. Çıkmak için bir tuşa bas...");
        Console.ReadKey ();
        }
    }
}
        
    

=======
namespace sayi_tamini_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zorlukseviyeleri zorlukSeviyesi = zorlukseviyelerisecimi();
            int maksimumSayi = MaksimumSayi(zorlukSeviyesi);
            int maksimumTahmin = MaksimumTahmin(zorlukSeviyesi);
        }

        enum zorlukseviyeleri { Kolay, Normal, Zor, Uzman }

        static zorlukseviyeleri zorlukseviyelerisecimi()
        {
            Console.WriteLine("Zorluk derecesini seciniz:");
            Console.WriteLine("1- Kolay (1-50, 10 tahmin)");
            Console.WriteLine("2- Normal (1-100, 7 tahmin)");
            Console.WriteLine("3- Zor (1-500, 8 tahmin)");
            Console.WriteLine("4- Uzman (1-1000, 10 tahmin)");

            while (true)
            {
                Console.Write("Seciminiz (1-4): ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out int secim) && secim >= 1 && secim <= 4)
                {
                    return (zorlukseviyeleri)(secim - 1);
                }

                Console.WriteLine("Hatali secim! Lutfen 1 ile 4 arasinda bir sayi giriniz.");
            }
        }

        static int MaksimumSayi(zorlukseviyeleri zorlukSeviyesi)
        {
            if (zorlukSeviyesi == zorlukseviyeleri.Kolay) return 50;
            if (zorlukSeviyesi == zorlukseviyeleri.Normal) return 100;
            if (zorlukSeviyesi == zorlukseviyeleri.Zor) return 500;
            return 1000; // Uzman
        }

        static int MaksimumTahmin(zorlukseviyeleri zorlukSeviyesi)
        {
            if (zorlukSeviyesi == zorlukseviyeleri.Kolay) return 10;
            if (zorlukSeviyesi == zorlukseviyeleri.Normal) return 7;
            if (zorlukSeviyesi == zorlukseviyeleri.Zor) return 8;
            return 10; // Uzman
        }
    }
}

