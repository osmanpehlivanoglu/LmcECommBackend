using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KampanyaDto:IDto
    {
        public int KampanyaId { get; set; }
        public int UrunId { get; set; }
        public decimal Yuzde { get; set; }
        public string StokKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal ToptanciFiyati { get; set; }
        public decimal BayiFiyati { get; set; }
        public decimal PerakendeFiyati { get; set; }
        public decimal StokMiktari { get; set; }
        public string UrunResmi { get; set; }
        public DateTime Tarih { get; set; }
        public string KategoriAdi { get; set; }
        public string MarkaAdi { get; set; }
    }
}
