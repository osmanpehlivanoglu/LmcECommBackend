using Business.Abstract.Lmc;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Lmc
{
    public class LmcKampanyaManager : ILmcKampanyaService
    {
        ILmcKampanyaDal _kampanyaDal;

        public LmcKampanyaManager(ILmcKampanyaDal kampanyaDal)
        {
            _kampanyaDal = kampanyaDal;
        }

        public async Task<IResult> Add(Kampanya kampanya)
        {
            await _kampanyaDal.Add(kampanya);
            return new SuccessResult(Messages.KampanyaEklendi);
        }

        public async Task<IResult> Delete(Kampanya kampanya)
        {
            await _kampanyaDal.Delete(kampanya);
            return new SuccessResult(Messages.KampanyaSilindi);
        }

        public async Task<IDataResult<List<Kampanya>>> GetAll()
        {
            return new SuccessDataResult<List<Kampanya>>(await _kampanyaDal.GetAll());
        }

        public async Task<IDataResult<List<KampanyaDto>>> GetAllDto()
        {
            return new SuccessDataResult<List<KampanyaDto>>(await _kampanyaDal.GetAllDto());
        }

        public async Task<IDataResult<Kampanya>> GetById(int kampanyaId)
        {
            return new SuccessDataResult<Kampanya>(await _kampanyaDal.Get(k => k.KampanyaId == kampanyaId));
        }

        public async Task<IDataResult<Kampanya>> GetByUrunId(int urunId)
        {
            return new SuccessDataResult<Kampanya>(await _kampanyaDal.Get(k => k.UrunId == urunId));
        }

        public async Task<IDataResult<KampanyaDto>> GetDtoByUrunId(int urunId)
        {
            return new SuccessDataResult<KampanyaDto>(await _kampanyaDal.GetDto(k => k.UrunId == urunId));
        }

        public async Task<IResult> Update(Kampanya kampanya)
        {
            await _kampanyaDal.Update(kampanya);
            return new SuccessResult(Messages.KampanyaGuncellendi);
        }
    }
}
