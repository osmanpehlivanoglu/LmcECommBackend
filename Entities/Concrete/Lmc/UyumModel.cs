using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UyumModel:IEntity
    {
        public int UyumModelId { get; set; }
        public int UyumMarkaId { get; set; }
        public string UyumModelAdi { get; set; }
    }
}
