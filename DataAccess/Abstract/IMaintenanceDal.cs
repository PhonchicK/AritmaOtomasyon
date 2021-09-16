using Entities.Concrete;
using Entities.Dto;
using Core.DataAccess;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DataAccess.Abstract
{
    public interface IMaintenanceDal : IEntityRepository<Maintenance>
    {
        MaintenanceDto GetDetails(Expression<Func<MaintenanceDto, bool>> filter);
        List<MaintenanceDto> GetAllDetails(Expression<Func<MaintenanceDto, bool>> filter = null);
    }
}
