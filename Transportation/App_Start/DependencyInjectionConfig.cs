﻿using DryIoc;
using DryIoc.WebApi;
using System.Web.Http;
using Transportation.Data;
using Transportation.Interfaces;
using Transportation.Service;

namespace Transportation.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDependencyInjection(HttpConfiguration config)
        {
            var container = new Container();
            Configure(container).WithWebApi(config);
        }

        private static Container Configure(Container container)
        {
            container.RegisterInstance(new DataContext());

            container.Register<IBusService, BusService>(Reuse.Singleton);

            return container;
        }
    }
}