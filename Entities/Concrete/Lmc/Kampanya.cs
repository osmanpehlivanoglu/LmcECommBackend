using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kampanya:IEntity
    {
        public int KampanyaId { get; set; }
        public int UrunId { get; set; }
        public decimal Yuzde { get; set; }
    }
}
