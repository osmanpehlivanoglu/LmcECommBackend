using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcDistrictService
    {
        Task<IDataResult<List<District>>> GetAll();
        Task<IDataResult<List<District>>> GetAllByCityId(int cityId);
        Task<IDataResult<District>> GetById(int districtId);
    }
}
