using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcUyumMarkaService
    {
        Task<IDataResult<List<UyumMarka>>> GetAll();
        Task<IDataResult<UyumMarka>> GetById(int uyumMarkaId);
        Task<IResult> Add(UyumMarka uyumMarka);
        Task<IResult> Update(UyumMarka uyumMarka);
        Task<IResult> Delete(UyumMarka uyumMarka);
    }
}
