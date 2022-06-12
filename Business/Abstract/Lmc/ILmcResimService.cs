using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcResimService
    {
        IDataResult<List<Resim>> GetAll();
        IDataResult<List<Resim>> GetImagesByUrunId(int urunId);
        IDataResult<Resim> GetById(int resimId);

        IResult Add(IFormFile file, Resim resim);
        IResult Update(IFormFile file, Resim resim);
        IResult Delete(Resim resim);
        
    }
}
