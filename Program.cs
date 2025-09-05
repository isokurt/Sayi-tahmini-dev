
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Program_Bera
{
    internal class Program
    {
        static void Main ( string [ ] args )
        {
        }

        static int SeviyeSec ()
        {
        Console.WriteLine ("=== Tahmin Oyunu: Seviye Seçimi ===\n");
        Console.WriteLine ("1 - Kolay    (1 - 50 arası, 10 tahmin hakkı)");
        Console.WriteLine ("2 - Orta     (1 - 100 arası, 7 tahmin hakkı)");
        Console.WriteLine ("3 - Zor      (1 - 500 arası, 8 tahmin hakkı)");
        Console.WriteLine ("4 - Uzman    (1 - 1000 arası, 10 tahmin hakkı)");
        Console.WriteLine ();

        for(; ; )
        {
        Console.Write ("Seçiminiz (1-4): ");
        string giris = Console.ReadLine();

        if(int.TryParse (giris, out int secim) && secim >= 1 && secim <= 4)
        {
        return secim;
        }

        Console.WriteLine ("Hatalı giriş yaptınız, lütfen 1 ile 4 arasında bir değer girin.\n");
        }
        }

        static (int Baslangic, int Bitis, int TahminHakki) SeviyeBilgileri ( int seviye )
        {
        return seviye switch
        {
            1 => (1, 50, 10),
            2 => (1, 100, 7),
            3 => (1, 500, 8),
            4 => (1, 1000, 10),
            _ => (1, 100, 7)
        };
        }

    }
  }
}
