using CA_OgrenciIsleri.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OgrenciIsleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciConcrete concrete = new OgrenciConcrete();

            concrete.AddOgrenci(new Ogrenci()
            {
                Id = 1,
                Ad = "Aziz",
                Soyad = "Bilgili"
            }
            ) ;

            concrete.AddOgrenci(new Ogrenci()
            {
                Id = 2,
                Ad = "Fatih",
                Soyad = "Gunalp"
            }
            );

            concrete.AddOgrenci(new Ogrenci()
            {
                Id = 3,
                Ad = "Mauro",
                Soyad = "Icardi"
            }
            );

            foreach (Ogrenci o in concrete.GetOgrenciler())
            {
                Console.WriteLine( o );
            }

            Ogrenci ogrenci = new Ogrenci()
            {
                Id = 1,
                Ad = "Ali",
                Soyad = "Bilgili"
            };

            bool isUpdated = concrete.UpdateOgrenci( ogrenci );

            if( isUpdated )
            {
                Console.WriteLine("Guncelleme basarili oldu.");

                foreach (Ogrenci o in concrete.GetOgrenciler())
                {
                    Console.WriteLine(o);
                }
            }
            else
            {
                Console.WriteLine("Guncelleme basarisiz oldu.");
            }

            bool isDeleted = concrete.DeleteOgrenci(2);

            if (isDeleted)
            {
                Console.WriteLine("Silme islemi basarili oldu.");

                foreach (Ogrenci o in concrete.GetOgrenciler())
                {
                    Console.WriteLine(o);
                }
            }
            else
            {
                Console.WriteLine("Silme islemi basarisiz oldu.");
            }


            Console.Read();


        }
    }
}
