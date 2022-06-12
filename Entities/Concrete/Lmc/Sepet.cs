using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sepet:IEntity
    {
        public int SepetId { get; set; }
        public int OnayId { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }
        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
        public string TarihStr { get; set; }
        
    }
}
