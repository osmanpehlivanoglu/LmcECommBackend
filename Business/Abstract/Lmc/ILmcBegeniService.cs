using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcBegeniService
    {
        Task<IDataResult<List<Begeni>>> GetAll();
        Task<IDataResult<Begeni>> GetById(int begeniId);
        Task<IDataResult<List<Begeni>>> GetAllByKullaniciId(int kullaniciId);
        Task<IResult> Add(Begeni begeni);
        Task<IResult> Update(Begeni begeni);
        Task<IResult> Delete(Begeni begeni);

        Task<IDataResult<List<BegeniDto>>> GetAllDto();
        Task<IDataResult<List<BegeniDto>>> GetAllDtoByKullaniciId(int kullaniciId);
    }
}
