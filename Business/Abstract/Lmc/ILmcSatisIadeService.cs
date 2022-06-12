using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcSatisIadeService
    {
        Task<IDataResult<List<SatisIade>>> GetAll();
        Task<IDataResult<SatisIade>> GetBySatisId(int satisId);
        Task<IDataResult<SatisIade>> GetById(int satisIadeId);
        Task<IResult> Add(SatisIade satisIade);
        Task<IResult> Update(SatisIade satisIade);
        Task<IResult> Delete(SatisIade satisIade);
    }
}
