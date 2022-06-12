using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcToptanciService
    {
        Task<IDataResult<List<Toptanci>>> GetAll();
        Task<IDataResult<Toptanci>> GetById(int toptanciId);
        Task<IResult> Add(Toptanci toptanci);
        Task<IResult> Update(Toptanci toptanci);
        Task<IResult> Delete(Toptanci toptanci);
    }
}
