﻿using CA_OgrenciIsleri.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OgrenciIsleri
{
    public class Ogrenci:BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"{Id}  -  {Ad}  -  {Soyad}";
        }
    }
}
