using QuarterlySalesApp.Models.DomainModels;

namespace QuarterlySalesApp.Models.DataAccess
{
    public class SalesQueryOptions : QueryOptions<Sales>
    {
        public void SortFilter(SalesGridBuilder builder)
        {
            if (builder.IsFilterByEmployee)
            {
                Where = s => s.EmployeeId == builder.CurrentRoute.EmployeeFilter.ToInt();
            }
            if (builder.IsFilterByYear)
            {
                Where = s => s.Year == builder.CurrentRoute.YearFilter.ToInt();
            }
            if (builder.IsFilterByYear)
            {
                Where = s => s.Quarter == builder.CurrentRoute.QuarterFilter.ToInt();
            }
            if (builder.IsSortZByQuarter)
            {
                OrderBy = s => s.Quarter;
            }
            else if (builder.IsSortByEmployee)
            {
                OrderBy = s => s.Employee.FirstName;
            }
            else if (builder.IsSortByAmount)
            {
                OrderBy = s => s.Amount;
            }
            else
            {
                OrderBy = s => s.Year;
            }
        }
    }
}
