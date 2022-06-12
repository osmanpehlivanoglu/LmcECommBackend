using Core.Entities;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }
    }
}
