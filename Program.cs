using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
