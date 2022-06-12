using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Toptanci:IEntity
    {
        public int ToptanciId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Firma { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
}
