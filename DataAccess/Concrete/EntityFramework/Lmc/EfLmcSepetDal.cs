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
    public class EfLmcSepetDal : EfEntityRepositoryBase<Sepet, LmcContext>, ILmcSepetDal
    {


        public async Task<List<SepetDto>> GetAllDto(Expression<Func<Sepet, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {

                var result = from sepet in filter is null ? context.Sepetler : context.Sepetler.Where(filter)
                             join urun in context.Urunler on sepet.UrunId equals urun.UrunId
                             join onay in context.Onaylar on sepet.OnayId equals onay.OnayId
                             join satis in context.Satislar on sepet.SepetId equals satis.SepetId
                             join satinalim in context.SatinAlimlar on sepet.SepetId equals satinalim.SepetId
                             join kullanici in context.Users on sepet.MusteriId equals kullanici.UserId
                             join satici in context.Toptancilar on satinalim.SaticiId equals satici.ToptanciId

                             select new SepetDto
                             {
                                 SepetId = sepet.SepetId,
                                 MusteriId = kullanici.UserId,
                                 MusteriAdi = kullanici.FirstName,
                                 MusteriSoyadi = kullanici.LastName,
                                 MusteriFirma = kullanici.Firma,
                                 MusteriEmail = kullanici.Email,
                                 MusteriTelefon = kullanici.Telefon,
                                 MusteriAdres = kullanici.Adres,
                                 UrunId = sepet.UrunId,
                                 UrunAdi = urun.UrunAdi,
                                 StokKodu = urun.StokKodu,
                                 AlisFiyati = urun.AlisFiyati,
                                 Adet = sepet.Adet,
                                 Fiyat = sepet.Fiyat,
                                 Durum = sepet.Durum,
                                 Tarih = sepet.Tarih,
                                 OnayId = sepet.OnayId,
                                 OnayAdi = onay.OnayAdi,
                                 SaticiId = satinalim.SaticiId,
                                 SaticiAdi = satici.FirstName,
                                 SaticiSoyadi = satici.LastName,
                                 SaticiFirma = satici.Firma,
                                 SaticiEmail = satici.Email,
                                 SaticiTelefon = satici.Telefon,
                                 SaticiAdres = satici.Adres,
                                 SatinAlimId = satinalim.SatinAlimId,
                                 SatisId = satis.SatisId,
                                 TarihStr = sepet.TarihStr



                             };

                return await result.ToListAsync();
            }
        }

        public async Task<SepetDto> GetDto(Expression<Func<SepetDto, bool>> filter = null)
        {
            using (LmcContext context = new LmcContext())
            {
                var result = from sepet in context.Sepetler
                             join urun in context.Urunler on sepet.UrunId equals urun.UrunId
                             join onay in context.Onaylar on sepet.OnayId equals onay.OnayId
                             join satis in context.Satislar on sepet.SepetId equals satis.SepetId
                             join satinalim in context.SatinAlimlar on sepet.SepetId equals satinalim.SepetId
                             join kullanici in context.Users on sepet.MusteriId equals kullanici.UserId
                             join satici in context.Toptancilar on satinalim.SaticiId equals satici.ToptanciId

                             select new SepetDto
                             {
                                 SepetId = sepet.SepetId,
                                 MusteriId = kullanici.UserId,
                                 MusteriAdi = kullanici.FirstName,
                                 MusteriSoyadi = kullanici.LastName,
                                 MusteriFirma = kullanici.Firma,
                                 MusteriEmail = kullanici.Email,
                                 MusteriTelefon = kullanici.Telefon,
                                 MusteriAdres = kullanici.Adres,
                                 UrunId = sepet.UrunId,
                                 UrunAdi = urun.UrunAdi,
                                 StokKodu = urun.StokKodu,
                                 AlisFiyati = urun.AlisFiyati,
                                 Adet = sepet.Adet,
                                 Fiyat = sepet.Fiyat,
                                 Durum = sepet.Durum,
                                 Tarih = sepet.Tarih,
                                 OnayId = sepet.OnayId,
                                 OnayAdi = onay.OnayAdi,
                                 SaticiId = satinalim.SaticiId,
                                 SaticiAdi = satici.FirstName,
                                 SaticiSoyadi = satici.LastName,
                                 SaticiFirma = satici.Firma,
                                 SaticiEmail = satici.Email,
                                 SaticiTelefon = satici.Telefon,
                                 SaticiAdres = satici.Adres,
                                 SatinAlimId = satinalim.SatinAlimId,
                                 SatisId = satis.SatisId,
                                 TarihStr = sepet.TarihStr
                             };

                return filter == null ? await result.SingleOrDefaultAsync() : await result.SingleOrDefaultAsync(filter);

            }
        }
    }
}
