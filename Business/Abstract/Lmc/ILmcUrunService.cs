using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcUrunService
    {
        Task<IDataResult<List<Urun>>> GetAll();
        Task<IDataResult<List<Urun>>> GetAllByCategoryId(int kategoriId);
        Task<IDataResult<List<Urun>>> GetAllByUnitPricePurchase(decimal min, decimal max);
        Task<IDataResult<List<Urun>>> GetAllByUnitPriceGrocer(decimal min, decimal max);
        Task<IDataResult<List<Urun>>> GetAllByUnitPriceDealer(decimal min, decimal max);
        Task<IDataResult<List<Urun>>> GetAllByUnitPriceRetail(decimal min, decimal max);
        Task<IDataResult<Urun>> GetById(int urunId);
        Task<IResult> Add(Urun urun);
        Task<IResult> Update(Urun urun);
        Task<IResult> Delete(Urun urun);
        Task<IResult> AddTransactionalTest(Urun urun);



        Task<IDataResult<List<UrunDto>>> GetAllDto();
        Task<IDataResult<List<UrunDto>>> GetAllDtoByCategory(int categoryId);
        Task<IDataResult<List<UrunDto>>> GetAllDtoByBrand(int brandId);
        Task<IDataResult<List<UrunDto>>> GetAllDtoByCategoryAndBrand(int categoryId, int brandId);
        Task<IDataResult<UrunDto>> GetDtoByProduct(int carId);


        //IDataResult<List<UrunDto>> GetAllDtoByUnitPricePurchase(decimal min, decimal max);
        //IDataResult<List<UrunDto>> GetAllDtoByUnitPriceGrocer(decimal min, decimal max);
        //IDataResult<List<UrunDto>> GetAllDtoByUnitPriceDealer(decimal min, decimal max);
        //IDataResult<List<UrunDto>> GetAllDtoByUnitPriceRetail(decimal min, decimal max);




    }
}
