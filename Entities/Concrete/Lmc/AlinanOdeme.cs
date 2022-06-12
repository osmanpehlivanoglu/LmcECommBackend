using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AlinanOdeme:IEntity
    {
        public int AlinanOdemeId { get; set; }
        public int MusteriId { get; set; }
        public decimal Miktar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
