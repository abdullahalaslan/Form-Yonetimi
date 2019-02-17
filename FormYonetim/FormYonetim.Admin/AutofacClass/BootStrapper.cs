using Autofac;
using Autofac.Integration.Mvc;
using FormYonetimi.Core.Infrastructure;
using FormYonetimi.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormYonetim.Admin.AutofacClass
{
    public class BootStrapper
    {
        public static void RunConfig()
        {
            BuildAutofac();
        }

        //BOOT ASAMASINDA CALISACAK

        private static void BuildAutofac()

        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AdminRepository>().As<IAdminRepository>();
            builder.RegisterType<FormRepository>().As<IFormRepository>();
            builder.RegisterType<KullaniciRepository>().As<IKullaniciRepository>();
       

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}