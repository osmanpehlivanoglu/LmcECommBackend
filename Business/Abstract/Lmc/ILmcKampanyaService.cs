using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Lmc
{
    public interface ILmcKampanyaService
    {
        Task<IDataResult<List<Kampanya>>> GetAll();
        Task<IDataResult<Kampanya>> GetById(int kampanyaId);
        Task<IDataResult<Kampanya>> GetByUrunId(int urunId);
        Task<IResult> Add(Kampanya kampanya);
        Task<IResult> Update(Kampanya kampanya);
        Task<IResult> Delete(Kampanya kampanya);


        Task<IDataResult<List<KampanyaDto>>> GetAllDto();
        Task<IDataResult<KampanyaDto>> GetDtoByUrunId(int urunId);

    }
}
