using QuarterlySalesApp.Models.DomainModels;
using System;
using System.Collections.Generic;

namespace QuarterlySalesApp.Models.ViewModels
{
    public class SalesListViewModel
    {
        public IEnumerable<Sales> Sales { get; set; }
        public RouteValueDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }

        //  For our filter drop-downs
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<int> Years
        {
            get
            {
                List<int> Years = new List<int>();
                int foundingYear = 1995, currentYear = DateTime.Today.Year;
                for (int yr = currentYear; yr >= foundingYear; yr--)
                {
                    Years.Add(yr);
                }

                return Years;
            }
        }

        public IEnumerable<int> Quarters
        {
            get
            {
                List<int> quarters = new List<int>();
                for (int q = 1; q <= 4; ++q)
                {
                    quarters.Add(q);
                }

                return quarters;
            }
        }

    }
}
