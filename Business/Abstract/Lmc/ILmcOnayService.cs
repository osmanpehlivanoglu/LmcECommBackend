using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcOnayService
    {
        Task<IDataResult<List<Onay>>> GetAll();
        Task<IDataResult<Onay>> GetById(int onayId);
        Task<IResult> Add(Onay onay);
        Task<IResult> Update(Onay onay);
        Task<IResult> Delete(Onay onay);
    }
}
