using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OgrenciIsleri.Concretes
{
    public class OgrenciConcrete : IOgrenci
    {
        private static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void AddOgrenci(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
        }

        public bool DeleteOgrenci(int id)
        {
            foreach(Ogrenci o in ogrenciler)
            {
                if (o.Id == id)
                {
                    ogrenciler.Remove(o);
                    return true;
                }
            }

            return false;
        }

        public Ogrenci GetOgrenci(int id)
        {
            foreach (Ogrenci o in ogrenciler)
            {
                if (o.Id == id)
                {
                    return o;
                }
            }

            return null;
        }

        public List<Ogrenci> GetOgrenciler()
        {
            return ogrenciler;
        }

        public bool UpdateOgrenci(Ogrenci updated)
        {
            foreach (Ogrenci o in ogrenciler)
            {
                if (o.Id == updated.Id)
                {
                    o.Ad = updated.Ad;
                    o.Soyad = updated.Soyad;
                    return true;
                }
            }

            return false;
        }

        
    }
}
