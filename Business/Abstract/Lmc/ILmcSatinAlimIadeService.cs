using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcSatinAlimIadeService
    {
        Task<IDataResult<List<SatinAlimIade>>> GetAll();
        Task<IDataResult<SatinAlimIade>> GetBySatinAlimId(int satinAlimId);
        Task<IDataResult<SatinAlimIade>> GetById(int satinAlimIadeId);
        Task<IResult> Add(SatinAlimIade satinAlimIade);
        Task<IResult> Update(SatinAlimIade satinAlimIade);
        Task<IResult> Delete(SatinAlimIade satinAlimIade);
    }
}
