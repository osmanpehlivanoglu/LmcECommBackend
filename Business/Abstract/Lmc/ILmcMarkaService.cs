using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcMarkaService
    {
        Task<IDataResult<List<Marka>>> GetAll();
        Task<IDataResult<List<Marka>>> GetAllByKategoriId(int kategoriId);
        Task<IDataResult<Marka>> GetById(int markaId);
        Task<IResult> Add(Marka marka);
        Task<IResult> Update(Marka marka);
        Task<IResult> Delete(Marka marka);
    }
}
