using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Resim:IEntity
    {
        public int ResimId { get; set; }
        public int UrunId { get; set; }
        public string ResimAdresi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
