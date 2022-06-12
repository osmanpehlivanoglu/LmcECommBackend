using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    
    public class EfLmcUrunDal : EfEntityRepositoryBase<Urun, LmcContext>, ILmcUrunDal
    {
        
        public async Task<List<UrunDto>> GetAllDto(Expression<Func<Urun, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {

                var result = from u in filter is null ? context.Urunler : context.Urunler.Where(filter)
                             join k in context.Kategoriler on u.KategoriId equals k.KategoriId
                             join m in context.Markalar on u.MarkaId equals m.MarkaId
                             select new UrunDto
                             {
                                 UrunId = u.UrunId,
                                 KategoriId = k.KategoriId,
                                 KategoriAdi = k.KategoriAdi,
                                 MarkaId = m.MarkaId,
                                 MarkaAdi = m.MarkaAdi,
                                 UyumMarkaId = u.UyumMarkaId,
                                 UyumModelId = u.UyumModelId,
                                 StokKodu = u.StokKodu,
                                 UrunAdi = u.UrunAdi,
                                 Aciklama = u.Aciklama,
                                 AlisFiyati = u.AlisFiyati,
                                 ToptanciFiyati = u.ToptanciFiyati,
                                 BayiFiyati = u.BayiFiyati,
                                 PerakendeFiyati = u.PerakendeFiyati,
                                 StokMiktari = u.StokMiktari,
                                 UrunResmi = (from i in context.Resimler where (u.UrunId == i.UrunId) select i.ResimAdresi).FirstOrDefault(),
                                 Tarih = (from i in context.Resimler where (u.UrunId == i.UrunId) select i.Tarih).FirstOrDefault(),
                                 SaticiId = m.ToptanciId,
                             };

                return await result.ToListAsync();

            }
        }

        public async Task<UrunDto> GetDtoByProduct(Expression<Func<UrunDto, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {
                var result = from u in context.Urunler
                             join k in context.Kategoriler on u.KategoriId equals k.KategoriId
                             join m in context.Markalar on u.MarkaId equals m.MarkaId
                             select new UrunDto
                             {
                                 UrunId = u.UrunId,
                                 KategoriId = u.KategoriId,
                                 KategoriAdi = k.KategoriAdi,
                                 MarkaId = u.MarkaId,
                                 MarkaAdi = m.MarkaAdi,
                                 UyumMarkaId = u.UyumMarkaId,
                                 UyumModelId = u.UyumModelId,
                                 StokKodu = u.StokKodu,
                                 UrunAdi = u.UrunAdi,
                                 Aciklama = u.Aciklama,
                                 AlisFiyati = u.AlisFiyati,
                                 ToptanciFiyati = u.ToptanciFiyati,
                                 BayiFiyati = u.BayiFiyati,
                                 PerakendeFiyati = u.PerakendeFiyati,
                                 StokMiktari = u.StokMiktari,
                                 UrunResmi = (from i in context.Resimler where (u.UrunId == i.UrunId) select i.ResimAdresi).FirstOrDefault(),
                                 Tarih = (from i in context.Resimler where (u.UrunId == i.UrunId) select i.Tarih).FirstOrDefault(),
                                 SaticiId = m.ToptanciId
                             };
                return filter == null ? await result.SingleOrDefaultAsync() : await result.SingleOrDefaultAsync(filter);

            }
        }
    }
}
