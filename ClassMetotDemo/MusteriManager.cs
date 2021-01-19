using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri add)
        {
            Console.WriteLine("---Eklenmiş Müşteri---");
            Console.WriteLine(add.Id + "-" + add.Name + " " + add.Surname);
            Console.WriteLine("Müşteri eklendi.");
            Console.WriteLine("-----------------------------");

        }
        public void MusteriRemove(Musteri remove)
        {
            Console.WriteLine("---Çıkarılmış Müşteri---");
            Console.WriteLine(remove.Id + "-" + remove.Name + " " + remove.Surname);
            Console.WriteLine("Müşteri çıkartıldı.");
            Console.WriteLine("----------------------");
        }

    }
}
