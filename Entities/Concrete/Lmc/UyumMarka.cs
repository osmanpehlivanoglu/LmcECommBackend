using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UyumMarka:IEntity
    {
        public int UyumMarkaId { get; set; }
        public string UyumMarkaAdi { get; set; }
    }
}
