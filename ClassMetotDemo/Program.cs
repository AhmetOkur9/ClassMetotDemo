using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi1 = new Musteri();
            kisi1.ID = 1;
            kisi1.Name = "Ahmet Kaan";
            kisi1.Surname = "Okur";

            Musteri kisi2 = new Musteri();
            kisi2.ID = 2;
            kisi2.Name = "Gökhan";
            kisi2.Surname = "Yılmaz";

            Musteri kisi3 = new Musteri();
            kisi3.ID = 3;
            kisi3.Name = "Dursun";
            kisi3.Surname = "Aydın";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(kisi1);
            Console.WriteLine("---------------------------------");
            musteriManager.Sil(kisi2);
            Console.WriteLine("---------------------------------");
            musteriManager.Ekle(kisi3);





        }

    }
}
