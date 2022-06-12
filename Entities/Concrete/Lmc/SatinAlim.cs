using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatinAlim:IEntity
    {
        public int SatinAlimId { get; set; }
        public int SepetId { get; set; }
        public int SaticiId { get; set; }
        
    }
}
