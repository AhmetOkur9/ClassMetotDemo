using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "  Bankanıza başarılı bir şekilde eklendi.");
            Console.WriteLine("Hesap Bilgileri:  ");
            Console.WriteLine("ID: "+ musteri.ID + " İsim: "+ musteri.Name +" Soyisim:  "+ musteri.Surname);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + "  Bankanızdan başarılı bir şekilde silindi. ");
        }


    }
}
