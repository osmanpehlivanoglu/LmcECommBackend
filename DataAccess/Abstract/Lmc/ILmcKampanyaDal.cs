using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILmcKampanyaDal:IEntityRepository<Kampanya>
    {
        Task<List<KampanyaDto>> GetAllDto(Expression<Func<Kampanya, bool>> filter = null);
        Task<KampanyaDto> GetDto(Expression<Func<KampanyaDto, bool>> filter = null);
    }
}
