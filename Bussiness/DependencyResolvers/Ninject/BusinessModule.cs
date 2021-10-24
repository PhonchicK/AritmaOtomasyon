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

            Bind<IMaintenanceDal>().To<EfMaintenanceDal>().InSingletonScope();
            Bind<IMaintenanceService>().To<MaintenanceManager>().InSingletonScope();

            Bind<IMaintenanceBaseDal>().To<EfMaintenanceBaseDal>().InSingletonScope();
            Bind<IMaintenanceBaseService>().To<MaintenanceBaseManager>().InSingletonScope();

            Bind<IInstalmentDal>().To<EfInstalmentDal>().InSingletonScope();
            Bind<IInstalmentService>().To<InstalmentManager>().InSingletonScope();

            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();

            Bind<IDebtDal>().To<EfDebtDal>().InSingletonScope();
            Bind<IDebtService>().To<DebtManager>().InSingletonScope();

            Bind<INoteDal>().To<EfNoteDal>().InSingletonScope();
            Bind<INoteService>().To<NoteManager>().InSingletonScope();
        }
    }
}
