using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Ufuk";
            musteri1.MusteriSoyad = "ORHAN";
            musteri1.MusteriYasi = 25;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyad = "DEMIROG";
            musteri2.MusteriYasi = 33;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Firat";
            musteri3.MusteriSoyad = "ORHAN";
            musteri3.MusteriYasi = 22;

            Musteri[] musterim = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("Foreach ile");
            foreach (var yazdirulen in musterim)
            {
                Console.WriteLine("*****Müsteriler ****");
                Console.WriteLine("Müşteri ID : " +yazdirulen.MusteriId);
                Console.WriteLine(yazdirulen.MusteriAdi);
                Console.WriteLine(yazdirulen.MusteriSoyad);
                Console.WriteLine(yazdirulen.MusteriYasi);
                Console.WriteLine("___________________________\n");
            }
            Console.WriteLine("For döngüsü ile");


            Console.WriteLine("*****Müsteriler ****");
            for (int i=0;i<musterim.Length;i++)
            {
               
                Console.WriteLine("Müşteri ID : " + musterim[i].MusteriId);
                Console.WriteLine(musterim[i].MusteriAdi);
                Console.WriteLine(musterim[i].MusteriSoyad);
                Console.WriteLine(musterim[i].MusteriYasi);
                Console.WriteLine("___________________________\n");
            }

            //Musteri Ekleme

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);

            //Musteri Silme

            MusteriManager musterimanager2 = new MusteriManager();
            musterimanager2.Sil(musteri1);
            musterimanager2.Sil(musteri2);
            musterimanager2.Sil(musteri3);


            Console.ReadLine();







        }
    }
}
