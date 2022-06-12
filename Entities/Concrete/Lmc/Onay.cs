using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Onay:IEntity
    {
        public int OnayId { get; set; }
        public string OnayAdi { get; set; }
    }
}
