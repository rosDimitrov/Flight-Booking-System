[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ABS.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ABS.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ABS.MVC.App_Start
{
    using System;
    using System.Web;
    using ABS.Interfaces;
    using ABS.Data;
    using ABS.Util;
    

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAirlineValidator>().To<AirlineValidator>();
            kernel.Bind<IAirportValidator>().To<AirportValidator>();
            kernel.Bind<IFlightValidator>().To<FlightValidator>();

            kernel.Bind<IAirlineRepository>().To<AirlineRepository>();
            kernel.Bind<IAirportRepository>().To<AirportRepository>();
            kernel.Bind<IFlightRepository>().To<FlightRepository>();
            kernel.Bind<ISeatRepository>().To<SeatRepository>();
            kernel.Bind<ISectionRepository>().To<SectionRepository>();

            kernel.Bind<IAirlineManager>().To<AirlineManager>();
            kernel.Bind<IAirportManager>().To<AirportManager>();
            kernel.Bind<IFlightManager>().To<FlightManager>();
            kernel.Bind<ISeatManager>().To<SeatManager>();
            kernel.Bind<ISectionManager>().To<SectionManager>();





        }
    }
}
