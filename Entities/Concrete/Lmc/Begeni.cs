using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Begeni:IEntity
    {
        public int BegeniId { get; set; }
        public int UrunId { get; set; }
        public int KullaniciId { get; set; }
    }
}
