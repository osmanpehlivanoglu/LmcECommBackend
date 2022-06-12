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
    public class LmcUyumModelManager : ILmcUyumModelService
    {
        ILmcUyumModelDal _uyumModelDal;

        public LmcUyumModelManager(ILmcUyumModelDal uyumModelDal)
        {
            _uyumModelDal = uyumModelDal;
        }

        public async Task<IResult> Add(UyumModel uyumModel)
        {
            await _uyumModelDal.Add(uyumModel);
            return new SuccessResult(Messages.UyumModelEklendi);
        }

        public async Task<IResult> Delete(UyumModel uyumModel)
        {
            await _uyumModelDal.Delete(uyumModel);
            return new SuccessResult(Messages.UyumModelSilindi);
        }

        public async Task<IDataResult<List<UyumModel>>> GetAll()
        {
            return new SuccessDataResult<List<UyumModel>>(await _uyumModelDal.GetAll());
        }

        public async Task<IDataResult<List<UyumModel>>> GetAllByUyumMarkaId(int uyumMarkaId)
        {
            return new SuccessDataResult<List<UyumModel>>(await _uyumModelDal.GetAll(u => u.UyumMarkaId == uyumMarkaId));
            
        }

        public async Task<IDataResult<UyumModel>> GetById(int uyumModelId)
        {
            return new SuccessDataResult<UyumModel>(await _uyumModelDal.Get(u => u.UyumModelId == uyumModelId));
        }

        public async Task<IResult> Update(UyumModel uyumModel)
        {
            await _uyumModelDal.Update(uyumModel);
            return new SuccessResult(Messages.UyumModelGuncellendi);
        }
    }
}
