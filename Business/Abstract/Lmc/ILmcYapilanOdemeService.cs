using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILmcYapilanOdemeService
    {
        Task<IDataResult<List<YapilanOdeme>>> GetAll();
        Task<IDataResult<YapilanOdeme>> GetById(int yapilanOdemeId);
        Task<IDataResult<List<YapilanOdeme>>> GetAllByToptanciId(int toptanciId);
        Task<IResult> Add(YapilanOdeme yapilanOdeme);
        Task<IResult> Update(YapilanOdeme yapilanOdeme);
        Task<IResult> Delete(YapilanOdeme yapilanOdeme);
    }
}
