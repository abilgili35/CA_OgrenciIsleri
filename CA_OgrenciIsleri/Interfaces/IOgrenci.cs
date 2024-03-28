using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OgrenciIsleri
{
    public interface IOgrenci
    {
        void AddOgrenci(Ogrenci ogrenci);
        List<Ogrenci> GetOgrenciler();
        Ogrenci GetOgrenci(int id);
        bool UpdateOgrenci(Ogrenci ogrenci);
        bool DeleteOgrenci(int id);
    }
}
