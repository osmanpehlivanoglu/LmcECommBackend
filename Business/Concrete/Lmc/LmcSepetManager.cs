using Business.Abstract.Lmc;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrete.Lmc
{
    public class LmcSepetManager : ILmcSepetService
    {
        ILmcSepetDal _sepetDal;

        public LmcSepetManager(ILmcSepetDal sepetDal)
        {
            _sepetDal = sepetDal;
        }


        public async Task<IDataResult<List<Sepet>>> GetAll()
        {
           
            return new SuccessDataResult<List<Sepet>>(await _sepetDal.GetAll());
        }
        public async Task<IResult> Add(Sepet sepet)
        {
            await _sepetDal.Add(sepet);
            return new SuccessResult(Messages.SepeteEklendi);
        }

        public async Task<IResult> Delete(Sepet sepet)
        {
            await _sepetDal.Delete(sepet);
            return new SuccessResult(Messages.SepettenCikarildi);
        }

        public async Task<IDataResult<List<Sepet>>> GetAllByMusteriIdAndDurum(int musteriId, bool durum)
        {
            return new SuccessDataResult<List<Sepet>>(await _sepetDal.GetAll(s => s.MusteriId == musteriId && s.Durum == durum));
        }

        public async Task<IResult> Update(Sepet sepet)
        {
            await _sepetDal.Update(sepet);
            return new SuccessResult(Messages.SepetGuncellendi);
        }

        public async Task<IDataResult<Sepet>> GetSepetBySepetId(int sepetId)
        {
            return new SuccessDataResult<Sepet>(await _sepetDal.Get(s => s.SepetId == sepetId));
        }


        public async Task<IDataResult<Sepet>> GetSepetByOnayIdAndDate(int onayId, string tarih)
        {

            return new SuccessDataResult<Sepet>(await _sepetDal.Get(s => s.OnayId == onayId && s.TarihStr== tarih));
        }



        public async Task<IDataResult<List<SepetDto>>> GetAllDto()
        {
            return new SuccessDataResult<List<SepetDto>>(await _sepetDal.GetAllDto());
        }

        public async Task<IDataResult<List<SepetDto>>> GetAllDtoByMusteriIdAndDurum(int musteriId, bool durum)
        {
            return new SuccessDataResult<List<SepetDto>>(await _sepetDal.GetAllDto(s => s.MusteriId == musteriId && s.Durum == durum));
        }

        

        public async Task<IDataResult<SepetDto>> GetDtoBySepetId(int sepetId)
        {
            return new SuccessDataResult<SepetDto>(await _sepetDal.GetDto(s => s.SepetId == sepetId));
        }

        public async Task<IDataResult<List<SepetDto>>> GetAllDtoByOnayIdAndDurum(int onayId, bool durum)
        {
            return new SuccessDataResult<List<SepetDto>>(await _sepetDal.GetAllDto(s => s.OnayId == onayId && s.Durum == durum));
        }

        public async Task<IDataResult<List<SepetDto>>> GetAllDtoByMusteriIdAndDurumAndOnayId(int musteriId, bool durum, int onayId)
        {
            return new SuccessDataResult<List<SepetDto>>(await _sepetDal.GetAllDto(s => s.MusteriId == musteriId && s.Durum == durum && s.OnayId == onayId));
        }
    }
}
