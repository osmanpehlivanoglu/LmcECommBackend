using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcCityService
    {
        Task<IDataResult<List<City>>> GetAll();
        Task<IDataResult<City>> GetById(int cityId);
    }
}
