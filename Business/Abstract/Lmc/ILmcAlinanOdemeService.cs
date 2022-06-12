using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcAlinanOdemeService
    {
        Task<IDataResult<List<AlinanOdeme>>> GetAll();
        Task<IDataResult<List<AlinanOdeme>>> GetAllByMusteriId(int musteriId);
        Task<IDataResult<AlinanOdeme>> GetById(int alinanOdemeId);
        Task<IResult> Add(AlinanOdeme alinanOdeme);
        Task<IResult> Update(AlinanOdeme alinanOdeme);
        Task<IResult> Delete(AlinanOdeme alinanOdeme);
    }
}
