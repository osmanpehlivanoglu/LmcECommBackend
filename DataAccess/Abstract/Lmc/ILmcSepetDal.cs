using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILmcSepetDal : IEntityRepository<Sepet>
    {
        Task<List<SepetDto>> GetAllDto(Expression<Func<Sepet, bool>> filter = null);
        Task<SepetDto> GetDto(Expression<Func<SepetDto, bool>> filter = null);
    }
}
