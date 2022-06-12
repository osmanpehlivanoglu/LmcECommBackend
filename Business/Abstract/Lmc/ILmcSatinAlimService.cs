using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcSatinAlimService
    {
        Task<IDataResult<List<SatinAlim>>> GetAll();
        Task<IDataResult<SatinAlim>> GetBySatinAlimId(int satinAlimId);
        Task<IDataResult<SatinAlim>> GetBySepetId(int sepetId);
        Task<IResult> Add(SatinAlim satinAlim);
        Task<IResult> Update(SatinAlim satinAlim);
        Task<IResult> Delete(SatinAlim satinAlim);
    }
}
