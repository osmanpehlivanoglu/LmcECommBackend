using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcUyumModelService
    {
        Task<IDataResult<List<UyumModel>>> GetAll();
        Task<IDataResult<List<UyumModel>>> GetAllByUyumMarkaId(int uyumMarkaId);
        Task<IDataResult<UyumModel>> GetById(int uyumModelId);
        Task<IResult> Add(UyumModel uyumModel);
        Task<IResult> Update(UyumModel uyumModel);
        Task<IResult> Delete(UyumModel uyumModel);
    }
}