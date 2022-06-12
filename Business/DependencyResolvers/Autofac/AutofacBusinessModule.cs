using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Abstract.Lmc;
using Business.Concrete;
using Business.Concrete.Lmc;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Lmc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LmcUrunManager>().As<ILmcUrunService>().SingleInstance();
            builder.RegisterType<EfLmcUrunDal>().As<ILmcUrunDal>().SingleInstance();

            builder.RegisterType<LmcKategoriManager>().As<ILmcKategoriService>().SingleInstance();
            builder.RegisterType<EfLmcKategoriDal>().As<ILmcKategoriDal>().SingleInstance();

            builder.RegisterType<LmcMarkaManager>().As<ILmcMarkaService>().SingleInstance();
            builder.RegisterType<EfLmcMarkaDal>().As<ILmcMarkaDal>().SingleInstance();

            builder.RegisterType<LmcUyumMarkaManager>().As<ILmcUyumMarkaService>().SingleInstance();
            builder.RegisterType<EfLmcUyumMarkaDal>().As<ILmcUyumMarkaDal>().SingleInstance();

            builder.RegisterType<LmcUyumModelManager>().As<ILmcUyumModelService>().SingleInstance();
            builder.RegisterType<EfLmcUyumModelDal>().As<ILmcUyumModelDal>().SingleInstance();

            builder.RegisterType<LmcToptanciManager>().As<ILmcToptanciService>().SingleInstance();
            builder.RegisterType<EfLmcToptanciDal>().As<ILmcToptanciDal>().SingleInstance();

            builder.RegisterType<LmcSatinAlimManager>().As<ILmcSatinAlimService>().SingleInstance();
            builder.RegisterType<EfLmcSatinAlimDal>().As<ILmcSatinAlimDal>().SingleInstance();

            builder.RegisterType<LmcSatinAlimIadeManager>().As<ILmcSatinAlimIadeService>().SingleInstance();
            builder.RegisterType<EfLmcSatinAlimIadeDal>().As<ILmcSatinAlimIadeDal>().SingleInstance();

            builder.RegisterType<LmcSatisManager>().As<ILmcSatisService>().SingleInstance();
            builder.RegisterType<EfLmcSatisDal>().As<ILmcSatisDal>().SingleInstance();

            builder.RegisterType<LmcSatisIadeManager>().As<ILmcSatisIadeService>().SingleInstance();
            builder.RegisterType<EfLmcSatisIadeDal>().As<ILmcSatisIadeDal>().SingleInstance();

            builder.RegisterType<LmcAlinanOdemeManager>().As<ILmcAlinanOdemeService>().SingleInstance();
            builder.RegisterType<EfLmcAlinanOdemeDal>().As<ILmcAlinanOdemeDal>().SingleInstance();

            builder.RegisterType<LmcYapilanOdemeManager>().As<ILmcYapilanOdemeService>().SingleInstance();
            builder.RegisterType<EfLmcYapilanOdemeDal>().As<ILmcYapilanOdemeDal>().SingleInstance();

            builder.RegisterType<LmcUserManager>().As<ILmcUserService>().SingleInstance();
            builder.RegisterType<EfLmcUserDal>().As<ILmcUserDal>().SingleInstance();

            builder.RegisterType<LmcOperationClaimManager>().As<ILmcOperationClaimService>().SingleInstance();
            builder.RegisterType<EfLmcOperationClaimDal>().As<ILmcOperationClaimDal>().SingleInstance();

            builder.RegisterType<LmcUserOperationClaimManager>().As<ILmcUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfLmcUserOperationClaimDal>().As<ILmcUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<LmcResimManager>().As<ILmcResimService>().SingleInstance();
            builder.RegisterType<EfLmcResimDal>().As<ILmcResimDal>().SingleInstance();

            builder.RegisterType<LmcSepetManager>().As<ILmcSepetService>().SingleInstance();
            builder.RegisterType<EfLmcSepetDal>().As<ILmcSepetDal>().SingleInstance();
            
            builder.RegisterType<LmcOnayManager>().As<ILmcOnayService>().SingleInstance();
            builder.RegisterType<EfLmcOnayDal>().As<ILmcOnayDal>().SingleInstance();

            builder.RegisterType<LmcBegeniManager>().As<ILmcBegeniService>().SingleInstance();
            builder.RegisterType<EfLmcBegeniDal>().As<ILmcBegeniDal>().SingleInstance();

            builder.RegisterType<LmcKampanyaManager>().As<ILmcKampanyaService>().SingleInstance();
            builder.RegisterType<EfLmcKampanyaDal>().As<ILmcKampanyaDal>().SingleInstance();

            builder.RegisterType<LmcOnayManager>().As<ILmcOnayService>().SingleInstance();
            builder.RegisterType<EfLmcOnayDal>().As<ILmcOnayDal>().SingleInstance();

            builder.RegisterType<LmcCityManager>().As<ILmcCityService>().SingleInstance();
            builder.RegisterType<EfLmcCityDal>().As<ILmcCityDal>().SingleInstance();

            builder.RegisterType<LmcDistrictManager>().As<ILmcDistrictService>().SingleInstance();
            builder.RegisterType<EfLmcDistrictDal>().As<ILmcDistrictDal>().SingleInstance();

            builder.RegisterType<LmcAuthManager>().As<ILmcAuthService>();



            builder.RegisterType<JwtHelper>().As<ITokenHelper>();



            


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}