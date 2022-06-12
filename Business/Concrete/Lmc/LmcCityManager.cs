using Business.Abstract.Lmc;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Lmc
{
    public class LmcCityManager : ILmcCityService
    {
        ILmcCityDal _cityDal;

        public LmcCityManager(ILmcCityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public async Task<IDataResult<List<City>>> GetAll()
        {
            return new SuccessDataResult<List<City>>(await _cityDal.GetAll());
        }

        public async Task<IDataResult<City>> GetById(int cityId)
        {
            return new SuccessDataResult<City>(await _cityDal.Get(c => c.CityId == cityId));
        }
    }
}
