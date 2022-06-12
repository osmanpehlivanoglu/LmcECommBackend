using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Musteri2;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //SatinAlimIadeDetayManager satinAlimIadeDetayManager = new SatinAlimIadeDetayManager(new EfSatinAlimIadeDetayDal());
            //var result = satinAlimIadeDetayManager.Add(new SatinAlimIadeDetay { SatinAlimIadeId = 1, Adet = 2, Fiyat = 3, UrunId = 2 });
            //Console.WriteLine(result.Message);

            //KategoriManager kategoriManager = new KategoriManager(new EfKategoriDal());
            //var result2 = kategoriManager.Add(new Kategori { KategoriAdi = "Batarya" });
            //Console.WriteLine(result2.Message);

            //UrunManager urunManager = new UrunManager(new EfUrunDal());
            //var result3 = urunManager.Add(new Urun { KategoriId = 1, MarkaId = 1, PerakendeFiyati = 10, StokKodu = "abc", StokMiktari = 100, ToptanFiyati = 5, UrunAdi = "Elma", UyumMarkaId = 1, UyumModelId = 1 });
            //Console.WriteLine(result3.Message);

            //var result4 = urunManager.GetAll().Data;

            //Console.WriteLine(result4.Count);
            //foreach (var urun in result4)
            //{
            //    Console.WriteLine(urun.UrunId + " " + urun.UrunAdi);
            //}


            //UrunManager urunManager2 = new UrunManager(new EfLmcUrunDal());
            //var result5 = urunManager2.Add(new Urun { KategoriId = 1, MarkaId = 1, PerakendeFiyati = 10, StokKodu = "abc", StokMiktari = 100, ToptanFiyati = 5, UrunAdi = "kılıf", UyumMarkaId = 1, UyumModelId = 1 });
            //Console.WriteLine(result5.Message);

            //foreach (var urun in urunManager2.GetAll().Data)
            //{
            //    Console.WriteLine(urun.UrunId + " " + urun.UrunAdi);
            //}


            //int sayi = 5;
            //if (sayi != 5 && sayi != 10)
            //{
            //    Console.WriteLine("naber");
            //}
            //else
            //{
            //    Console.WriteLine("hata");
            //}

            LmcUrunManager urunManager = new LmcUrunManager(new EfLmcUrunDal());
            var result3 = urunManager.Add(new Urun { KategoriId = 1, MarkaId = 1, PerakendeFiyati = 10, StokKodu = "abc", StokMiktari = 100, ToptanFiyati = 5, UrunAdi = "Elma", UyumMarkaId = 1, UyumModelId = 1 });
            Console.WriteLine(result3.Message);

            foreach (var urun in urunManager.GetAll().Data)
            {
                Console.WriteLine(urun.UrunId + " " + urun.UrunAdi);
            }

        }
    }
}
