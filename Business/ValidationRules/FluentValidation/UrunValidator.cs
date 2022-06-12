using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UrunValidator : AbstractValidator<Urun>
    {

        public UrunValidator()
        {

            RuleFor(u => u.UrunAdi).NotEmpty();
            RuleFor(u => u.UrunAdi).MinimumLength(2);
            

            //filanca kategorideki ürünün perakende fiyatı 10 ya da 10 dan büyük olmalı
            //RuleFor(u => u.PerakendeFiyati).GreaterThanOrEqualTo(10).When(u => u.KategoriId == 1);

            //KENDİMİZ KURAL YAZACAKSAK
            //RuleFor(u => u.UrunAdi).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");

        }

        private bool StartWithA(string arg)
        {
            //a ile başlıyorsa true döner
            return arg.StartsWith("A");
        }

    }
}