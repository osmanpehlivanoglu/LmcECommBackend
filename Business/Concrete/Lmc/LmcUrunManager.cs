using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcUrunManager:ILmcUrunService
    {
        ILmcUrunDal _urunDal;

        public LmcUrunManager(ILmcUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        //[SecuredOperation("urun.add,admin")]
        [ValidationAspect(typeof(UrunValidator))]
        [CacheRemoveAspect("ILmcUrunService.Get")]
        public async Task<IResult> Add(Urun urun)
        {

            IResult result = BusinessRules.Run(await CheckIfStockCodesTheSame(urun.StokKodu));

            if (result != null)
            {
                return result;
            }

            await _urunDal.Add(urun);
            return new SuccessResult(Messages.UrunEklendi);

        }

        [CacheRemoveAspect("ILmcUrunService.Get")]
        public async Task<IResult> Delete(Urun urun)
        {
            await _urunDal.Delete(urun);
            return new SuccessResult(Messages.UrunSilindi);
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAll()
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll());
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAllByCategoryId(int kategoriId)
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll(u=>u.KategoriId == kategoriId));
        }

        [CacheAspect]
        public async Task<IDataResult<Urun>> GetById(int urunId)
        {
            return new SuccessDataResult<Urun>(await _urunDal.Get(u => u.UrunId == urunId));
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAllByUnitPricePurchase(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll(u => u.AlisFiyati >= min && u.AlisFiyati <= max));
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAllByUnitPriceGrocer(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll(u => u.ToptanciFiyati >= min && u.ToptanciFiyati <= max));
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAllByUnitPriceDealer(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll(u => u.BayiFiyati >= min && u.BayiFiyati <= max));
        }

        [CacheAspect]
        public async Task<IDataResult<List<Urun>>> GetAllByUnitPriceRetail(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>(await _urunDal.GetAll(u => u.PerakendeFiyati >= min && u.PerakendeFiyati <= max));
        }

        [CacheRemoveAspect("ILmcUrunService.Get")]
        public async Task<IResult> Update(Urun urun)
        {
            await _urunDal.Update(urun);
            return new SuccessResult(Messages.UrunGuncellendi);
        }




        [TransactionScopeAspect]
        public async Task<IResult> AddTransactionalTest(Urun urun)
        {
            await Add(urun);
            if (urun.ToptanciFiyati > 1500000)
            {
                throw new Exception("");
            }
            await Add (urun);
            return null;
        }



        private async Task<IResult> CheckIfStockCodesTheSame(string stokKodu)
        {
            var result1 = await _urunDal.GetAll(u => u.StokKodu == stokKodu);
            var result = result1.Count;
            if (result > 0)
            {
                return new ErrorResult(Messages.AyniStokKodluUrun);
            }
            else
            {
                return new SuccessResult();
            }

        }


        public async Task<IDataResult<List<UrunDto>>> GetAllDto()
        {
            return new SuccessDataResult<List<UrunDto>>(await _urunDal.GetAllDto());
        }

        public async Task<IDataResult<List<UrunDto>>> GetAllDtoByCategory(int categoryId)
        {

            return new SuccessDataResult<List<UrunDto>>(await _urunDal.GetAllDto(u=>u.KategoriId == categoryId));

        }

        public async Task<IDataResult<List<UrunDto>>> GetAllDtoByBrand(int brandId)
        {
            return new SuccessDataResult<List<UrunDto>>(await _urunDal.GetAllDto(u => u.MarkaId == brandId));
        }

        public async Task<IDataResult<List<UrunDto>>> GetAllDtoByCategoryAndBrand(int categoryId, int brandId)
        {
            return new SuccessDataResult<List<UrunDto>>(await _urunDal.GetAllDto(u => u.KategoriId == categoryId && u.MarkaId == brandId));
         }

        public async Task<IDataResult<UrunDto>> GetDtoByProduct(int productId)
        {
            return new SuccessDataResult<UrunDto>(await _urunDal.GetDtoByProduct(u => u.UrunId == productId));
        }

        

        //public IDataResult<List<UrunDto>> GetAllDtoByUnitPricePurchase(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<UrunDto>>(_urunDal.GetAllDto(u => u.AlisFiyati >= min && u.AlisFiyati <= max));
        //}

        //public IDataResult<List<UrunDto>> GetAllDtoByUnitPriceGrocer(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<UrunDto>>(_urunDal.GetAllDto(u => u.ToptanciFiyati >= min && u.ToptanciFiyati <= max));
        //}

        //public IDataResult<List<UrunDto>> GetAllDtoByUnitPriceDealer(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<UrunDto>>(_urunDal.GetAllDto(u => u.BayiFiyati >= min && u.BayiFiyati <= max));
        //}

        //public IDataResult<List<UrunDto>> GetAllDtoByUnitPriceRetail(decimal min, decimal max)
        //{
        //    return new SuccessDataResult<List<UrunDto>>(_urunDal.GetAllDto(u => u.PerakendeFiyati >= min && u.PerakendeFiyati <= max));
        //}

    }
}
