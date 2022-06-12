
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SepetDto : IDto
    {
        public int SepetId { get; set; }

        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriFirma { get; set; }
        public string MusteriEmail { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriAdres { get; set; }

        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string StokKodu { get; set; }
        public decimal AlisFiyati { get; set; }

        public decimal Adet { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; }

        public DateTime Tarih {get; set;}
        public String TarihStr { get; set; }

        public int OnayId { get; set; }
        public string OnayAdi { get; set; }

        public int SaticiId { get; set; }
        public string SaticiAdi { get; set; }
        public string SaticiSoyadi { get; set; }
        public string SaticiFirma { get; set; }
        public string SaticiEmail { get; set; }
        public string SaticiTelefon { get; set; }
        public string SaticiAdres { get; set; }



        public int SatinAlimId { get; set; }
        public int SatisId { get; set; }


    }
}
