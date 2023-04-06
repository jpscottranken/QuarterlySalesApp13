using Microsoft.AspNetCore.DataProtection.Repositories;
using QuarterlySalesApp.Models.DomainModels;

namespace QuarterlySalesApp.Models.DataAccess
{
    public interface IUnitOfWork
    {
        Repository<Employee> Employees { get; }
        Repository<Sales> Sales { get; }
    }
}
