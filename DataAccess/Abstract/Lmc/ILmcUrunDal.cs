using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILmcUrunDal:IEntityRepository<Urun>
    {
        Task<List<UrunDto>> GetAllDto(Expression<Func<Urun, bool>> filter = null);
        Task<UrunDto> GetDtoByProduct(Expression<Func<UrunDto, bool>> filter = null);
    }
}
