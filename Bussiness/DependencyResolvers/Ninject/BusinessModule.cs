using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();

            Bind<ISaleDal>().To<EfSaleDal>().InSingletonScope();
            Bind<ISaleService>().To<SaleManager>().InSingletonScope();
        }
    }
}
