using Microsoft.EntityFrameworkCore;
using MyCompanyApp.Domain.Entities;
using System;
using System.Linq;

namespace MyCompanyApp.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItem()
        {
            return context.ServiceItems;
        }
        public ServiceItem GetServiceItemByID(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }
        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
        }
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem { Id = id });
            context.SaveChanges();
        }
    }
}
