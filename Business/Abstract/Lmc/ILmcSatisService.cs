using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcSatisService
    {
        Task<IDataResult<List<Satis>>> GetAll();
        Task<IDataResult<Satis>> GetBySatisId(int satisId);
        Task<IDataResult<Satis>> GetBySepetId(int sepetId);
        Task<IResult> Add(Satis satis);
        Task<IResult> Update(Satis satis);
        Task<IResult> Delete(Satis satis);
    }
}
