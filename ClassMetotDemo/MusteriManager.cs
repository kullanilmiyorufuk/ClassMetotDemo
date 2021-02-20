using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri) 
            {
            Console.WriteLine("Musteri Eklendi : " + musteri.MusteriAdi);
            }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine("Musteri Silindi " + musteri.MusteriAdi); 
        }

     
    }
}
