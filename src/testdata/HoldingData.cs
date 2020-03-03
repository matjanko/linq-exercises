using System.Collections.Generic;
using System.Linq;

namespace linq_exercises.src.testdata
{
    public class HoldingData
    {
        private readonly CompanyData companyData = new CompanyData();

        public List<Holding> GetHoldings() 
        {
            var companies = companyData.GetCompanies();
            var holdings = new List<Holding>();

            holdings.Add(new Holding(
                "Coca-cola",
                new List<Company>() 
                {
                    companies.ElementAt(0),
                    companies.ElementAt(1)
                }
            ));

            holdings.Add(new Holding(
                "Nestle",
                new List<Company>() 
                {
                    companies.ElementAt(2),
                    companies.ElementAt(3),
                    companies.ElementAt(4)
                }
            ));

            holdings.Add(new Holding(
                "Pepsico",
                new List<Company>() 
                {
                    companies.ElementAt(5),
                    companies.ElementAt(6),
                    companies.ElementAt(7)
                }
            ));

            return holdings;
        }
    }
}