using Microsoft.IdentityModel.Tokens;
using QuarterlySalesApp.Models.DomainModels;
using System.Security.Cryptography.X509Certificates;

namespace QuarterlySalesApp.Models.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private SalesContext context { get; set; }
        public UnitOfWork(SalesContext ctx)
        {
            context = ctx;
        }

        private Repository<Employee> employees;
        public Repository<Employee> Employees
        {
            get
            {
                if (employees == null)
                {
                    employees = new Repository<Employee>(context);
                }

                return employees;
            }
        }

        private Repository<Sales> sales;
        public Repository<Sales> Sales
        {
            get
            {
                if(sales == null)
                {
                    sales = new Repository<Sales> (context);
                }

                return sales;
            }
        }
    }
}
