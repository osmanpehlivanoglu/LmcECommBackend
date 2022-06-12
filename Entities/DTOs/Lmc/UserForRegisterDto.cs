using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForRegisterDto : IDto
    {
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KimlikNo { get; set; }
        public string Firma { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarasi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Password { get; set; }
        public bool MailGrubu { get; set; }
    }
}
