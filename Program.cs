internal class Program
{
    static void Main(string[] args)
    {
        // erisim_belirteci geri_donustipi metot_adi(parametreListesi/argüman);
        // {
        //     //komutlar;
        // }

        int a = 3;
        int b = 2;

        Console.WriteLine(a + b);

        int toplam = Topla(a, b);
        Console.WriteLine(toplam);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(toplam));

        int toplam2 = ornek.ArttırVeTopla(ref a,ref b);
        ornek.EkranaYazdir(Convert.ToString(toplam2));
        ornek.EkranaYazdir(Convert.ToString(a+b));


    }
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}