using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcSepetService
    {
        Task<IDataResult<List<Sepet>>> GetAll();
        Task<IDataResult<List<Sepet>>> GetAllByMusteriIdAndDurum(int musteriId, bool durum);
        Task<IDataResult<Sepet>> GetSepetBySepetId(int sepetId);

        //sepet idye ulaşmak için 
        Task<IDataResult<Sepet>> GetSepetByOnayIdAndDate(int onayId, string tarih);

        Task<IResult> Add(Sepet sepet);
        Task<IResult> Update(Sepet sepet);
        Task<IResult> Delete(Sepet sepet);


        Task<IDataResult<List<SepetDto>>> GetAllDto();
        Task<IDataResult<List<SepetDto>>> GetAllDtoByMusteriIdAndDurum(int musteriId, bool durum);
        Task<IDataResult<List<SepetDto>>> GetAllDtoByOnayIdAndDurum(int onayId, bool durum);
        Task<IDataResult<SepetDto>> GetDtoBySepetId(int sepetId);

        Task<IDataResult<List<SepetDto>>> GetAllDtoByMusteriIdAndDurumAndOnayId(int musteriId, bool durum, int onayId);

    }
}
