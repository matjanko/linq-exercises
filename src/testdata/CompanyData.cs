using System.Collections.Generic;
using System.Linq;

namespace linq_exercises.src.testdata
{
    public class CompanyData
    {
        private readonly UserData userData = new UserData();

        public List<Company> GetCompanies() 
        {
            var users = userData.GetUsers();
            var companies = new List<Company>();

            companies.Add(new Company(
                "Fanta", 
                new List<User>() 
                {
                    users.ElementAt(0),
                    users.ElementAt(1),
                    users.ElementAt(2)
                }));

            companies.Add(new Company(
                "Sprite", 
                new List<User>() 
                {
                    users.ElementAt(3),
                    users.ElementAt(4)
                }));

            companies.Add(new Company(
                "Nescafe", 
                new List<User>() 
                {
                    users.ElementAt(5),
                    users.ElementAt(6),
                    users.ElementAt(7),
                    users.ElementAt(8)
                }));

            companies.Add(new Company(
                "Gerber", 
                new List<User>() 
                {
                    users.ElementAt(9),
                    users.ElementAt(10),
                    users.ElementAt(11)
                }));

            companies.Add(new Company(
                "Nestea", 
                new List<User>() 
                {
                    users.ElementAt(12)
                }));

            companies.Add(new Company(
                "Lays", 
                new List<User>() 
                {
                    users.ElementAt(13),
                    users.ElementAt(14)
                }));

            companies.Add(new Company(
                "Pepsi", 
                new List<User>() 
                {
                    users.ElementAt(15),
                    users.ElementAt(16),
                    users.ElementAt(17)
                }));

            companies.Add(new Company(
                "Mirinda", 
                new List<User>() 
                {
                    users.ElementAt(18),
                    users.ElementAt(19)
                }));

            return companies;
        }

    }
}