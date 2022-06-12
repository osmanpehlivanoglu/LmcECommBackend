using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLmcKampanyaDal : EfEntityRepositoryBase<Kampanya, LmcContext>, ILmcKampanyaDal
    {
        public async Task<List<KampanyaDto>> GetAllDto(Expression<Func<Kampanya, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {

                var result = from kampanya in filter is null ? context.Kampanyalar : context.Kampanyalar.Where(filter)
                             join urun in context.Urunler on kampanya.UrunId equals urun.UrunId
                             join kategori in context.Kategoriler on urun.KategoriId equals kategori.KategoriId
                             join marka in context.Markalar on urun.MarkaId equals marka.MarkaId

                             select new KampanyaDto
                             {

                                 KampanyaId = kampanya.KampanyaId,
                                 UrunId = kampanya.UrunId,
                                 Yuzde = kampanya.Yuzde,
                                 UrunAdi = urun.UrunAdi,
                                 StokKodu = urun.StokKodu,
                                 AlisFiyati = urun.AlisFiyati,
                                 Aciklama = urun.Aciklama,
                                 ToptanciFiyati = urun.ToptanciFiyati,
                                 BayiFiyati = urun.BayiFiyati,
                                 PerakendeFiyati = urun.PerakendeFiyati,
                                 StokMiktari = urun.StokMiktari,
                                 UrunResmi = (from i in context.Resimler where (urun.UrunId == i.UrunId) select i.ResimAdresi).FirstOrDefault(),
                                 Tarih = (from i in context.Resimler where (urun.UrunId == i.UrunId) select i.Tarih).FirstOrDefault(),
                                 KategoriAdi = kategori.KategoriAdi,
                                 MarkaAdi = marka.MarkaAdi

                             };

                return await result.ToListAsync();
            }
        }

        public async Task<KampanyaDto> GetDto(Expression<Func<KampanyaDto, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {

                var result = from kampanya in context.Kampanyalar
                             join urun in context.Urunler on kampanya.UrunId equals urun.UrunId
                             join kategori in context.Kategoriler on urun.KategoriId equals kategori.KategoriId
                             join marka in context.Markalar on urun.MarkaId equals marka.MarkaId

                             select new KampanyaDto
                             {

                                 KampanyaId = kampanya.KampanyaId,
                                 UrunId = kampanya.UrunId,
                                 Yuzde = kampanya.Yuzde,
                                 UrunAdi = urun.UrunAdi,
                                 StokKodu = urun.StokKodu,
                                 AlisFiyati = urun.AlisFiyati,
                                 Aciklama = urun.Aciklama,
                                 ToptanciFiyati = urun.ToptanciFiyati,
                                 BayiFiyati = urun.BayiFiyati,
                                 PerakendeFiyati = urun.PerakendeFiyati,
                                 StokMiktari = urun.StokMiktari,
                                 UrunResmi = (from i in context.Resimler where (urun.UrunId == i.UrunId) select i.ResimAdresi).FirstOrDefault(),
                                 Tarih = (from i in context.Resimler where (urun.UrunId == i.UrunId) select i.Tarih).FirstOrDefault(),
                                 KategoriAdi = kategori.KategoriAdi,
                                 MarkaAdi = marka.MarkaAdi

                             };

                return filter == null ? await result.SingleOrDefaultAsync() : await result.SingleOrDefaultAsync(filter);
            }

            }
    }

}
