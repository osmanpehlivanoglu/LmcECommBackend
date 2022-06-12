using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class YapilanOdeme:IEntity
    {
        public int YapilanOdemeId { get; set; }
        public int ToptanciId { get; set; }
        public decimal Miktar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
