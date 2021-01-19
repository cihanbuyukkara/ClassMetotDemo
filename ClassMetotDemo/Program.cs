using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 196;
            musteri1.Name = "Cihan";
            musteri1.Surname = "Büyükkara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 250;
            musteri2.Name = "Meltem";
            musteri2.Surname = "Kaya";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1526;
            musteri3.Name = "Asuman";
            musteri3.Surname = "Natur";

            Musteri[] list = new Musteri[] { musteri1 };

            Console.WriteLine("Halihazırda müşteriler: ");
            foreach (Musteri SecilenListesi in list)
            {
                Console.WriteLine(SecilenListesi.Id + "-" + SecilenListesi.Name + " " + SecilenListesi.Surname);
                Console.WriteLine("------------------");
            }
            MusteriManager1 musteriFonksiyon = new MusteriManager1();
            musteriFonksiyon.MusteriAdd(musteri2);
            musteriFonksiyon.MusteriAdd(musteri3);

            Musteri[] MusteriListe = new Musteri[] {musteri1,musteri2,musteri3};
            MusteriManager1 musteriListe = new MusteriManager1();
            musteriListe.MusteriListing(musteri1);
            musteriListe.MusteriListing(musteri2);
            musteriListe.MusteriListing(musteri3);


            musteriFonksiyon.MusteriRemove(musteri1);
            musteriFonksiyon.MusteriRemove(musteri2);

            Musteri[] listRemove = new Musteri[] { musteri3};

            MusteriManager1 musteriListe1 = new MusteriManager1();
            musteriListe1.MusteriListing(musteri3);
            

            {

            }


        }
    }
}
