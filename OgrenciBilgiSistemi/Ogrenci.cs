using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public bool IsOK { get; set; }

        public Ogrenci(string ad, string soyad, DateTime dogumTarihi, string email, bool ısOK)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
            Email = email;
            IsOK = ısOK;
        }
    }
}
