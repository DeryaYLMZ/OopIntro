﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Explanation = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Name = "Kayısı";
            urun2.Price = 12;
            urun2.Explanation = "Malatya Kayısısı";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe
            foreach (Product urun in urunler) //Dzileri dönerken foreach kullanabiliyoruz.
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Explanation);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("-------Methodlar------");

            //encapsulation -- Ayrı ayrı düzensiz bir yapı yazmak yerine bir düzen içerisinde yazmamızı sağlamaktır.

            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun2);
            basketManager.EkleAlternatif("Armut", "Yeşil", 12); ;
            




            Console.ReadKey();
        }
    }
}
