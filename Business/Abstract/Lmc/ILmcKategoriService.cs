using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcKategoriService
    {
        Task<IDataResult<List<Kategori>>> GetAll();
        Task<IDataResult<Kategori>> GetById(int kategoriId);
        Task<IResult> Add(Kategori kategori);
        Task<IResult> Update(Kategori kategori);
        Task<IResult> Delete(Kategori kategori);

    }
}
