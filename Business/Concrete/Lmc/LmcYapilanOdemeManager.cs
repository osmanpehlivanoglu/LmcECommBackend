using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LmcYapilanOdemeManager : ILmcYapilanOdemeService
    {
        ILmcYapilanOdemeDal _yapilanOdemeDal;

        public LmcYapilanOdemeManager(ILmcYapilanOdemeDal YapilanOdemeDal)
        {
            _yapilanOdemeDal = YapilanOdemeDal;
        }

        public async Task<IResult> Add(YapilanOdeme YapilanOdeme)
        {
            await _yapilanOdemeDal.Add(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeEklendi);
        }

        public async Task<IResult> Delete(YapilanOdeme YapilanOdeme)
        {
            await _yapilanOdemeDal.Delete(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }

        public async Task<IDataResult<List<YapilanOdeme>>> GetAll()
        {
            return new SuccessDataResult<List<YapilanOdeme>>(await _yapilanOdemeDal.GetAll());
        }

        public async Task<IDataResult<List<YapilanOdeme>>> GetAllByToptanciId(int toptanciId)
        {
            return new SuccessDataResult<List<YapilanOdeme>>(await _yapilanOdemeDal.GetAll(y => y.ToptanciId == toptanciId));
        }

        public async Task<IDataResult<YapilanOdeme>> GetById(int YapilanOdemeId)
        {
            return new SuccessDataResult<YapilanOdeme>(await _yapilanOdemeDal.Get(y => y.YapilanOdemeId == YapilanOdemeId));
        }

        public async Task<IResult> Update(YapilanOdeme YapilanOdeme)
        {
            await _yapilanOdemeDal.Update(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }
    }
    }
