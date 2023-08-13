using MyCompanyApp.Domain.Entities;
using System;
using System.Linq;

namespace MyCompanyApp.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        public interface IServiceItemsRepository
        {
            IQueryable<ServiceItem> GetServiceItem();
            ServiceItem GetServiceItemById(Guid id);
            void SaveServiceItem(ServiceItem entity);
            void DeleteServiceItem(Guid id);
        }
    }
}
