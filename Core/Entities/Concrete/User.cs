using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId  { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KimlikNo { get; set; }
        public string Firma { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarasi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Adres { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public bool MailGrubu { get; set; }

    }
}
