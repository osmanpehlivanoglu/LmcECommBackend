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
    public class LmcDistrictManager : ILmcDistrictService
    {
        ILmcDistrictDal _districtDal;

        public LmcDistrictManager(ILmcDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public async Task<IDataResult<List<District>>> GetAll()
        {
            return new SuccessDataResult<List<District>>(await _districtDal.GetAll());
        }

        public async Task<IDataResult<List<District>>> GetAllByCityId(int cityId)
        {
            return new SuccessDataResult<List<District>>(await _districtDal.GetAll(d => d.CityId == cityId));
        }

        public async Task<IDataResult<District>> GetById(int districtId)
        {
            return new SuccessDataResult<District>(await _districtDal.Get(d => d.DistrictId == districtId));
        }
    }
}
