namespace Transkript;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Ders Sayısını giriniz: ");

        int ders_sayi = Convert.ToInt32(Console.ReadLine());

        double[] ders = new double[ders_sayi];

        int akts = 0;

        for (int i = 0; i < ders.Length; i++)
        {
            Console.Write("{0}. Dersin AKTS'si:",(i+1));
            int akt = Convert.ToInt32(Console.ReadLine());

            akts += akt;

            Console.Write("{0}. Dersin Vize notu:", (i + 1));
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}. Dersin Final notu:", (i + 1));
            int final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            ders[i] = NotOrtalama(vize, final, akt);

        }

        double ortalama = Toplam(ders) / akts;

        Console.WriteLine("Ortalama: "+ ortalama);

        /* Kontrol kodu:
        foreach (double i in ders)
        {
            Console.WriteLine(i);
        }*/

        Console.ReadLine();
        
    }

    public static double Toplam(double[] _ders)
    {
        double toplam = 0;

        for (int i = 0; i < _ders.Length; i++)
        {
            toplam += _ders[i];
        }

        return toplam;
    }

    public static double NotOrtalama(double _vize, double _final, int _akt)
    {
        double hesap = _vize * 0.4 + _final * 0.7;

        if (hesap > 100)
        {
            hesap = 100;
        }

        return hesap * _akt;
    }
}

