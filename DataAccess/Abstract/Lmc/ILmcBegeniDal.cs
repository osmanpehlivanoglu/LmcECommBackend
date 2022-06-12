using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILmcBegeniDal:IEntityRepository<Begeni>
    {
        Task<List<BegeniDto>> GetAllDto(Expression<Func<Begeni, bool>> filter = null);
        Task<BegeniDto> GetDto(Expression<Func<BegeniDto, bool>> filter = null);
    }
}
