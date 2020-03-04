using System;
using System.Linq;
using System.Collections.Generic;
using LinqExercises.Mock;
using LinqExercises.Domain;
using System.Text;

namespace LinqExercises.Logic
{
    public class WorkService : IWorkService
    {
        private readonly List<Holding> holdings;

        public WorkService()
        {
            this.holdings = new HoldingData().GetHoldings();
        }

        public long GetHoldingsWhereAreCompanies() 
        {
            var holdingsCount = (
                from holding in holdings 
                where (holding.Companies != null && holding.Companies.Count > 0)
                select holding).Count();

            return holdingsCount;
        }

        public List<string> GetHoldingNames() 
        {
            var holdingNames = (
                from holding in holdings
                select holding.Name.ToLower()).ToList();

            return holdingNames;
        }

        public string GetHoldingNamesAsString() 
        {
            var holdingNames = (
                from holding in holdings
                select holding.Name);

            return String.Join(", ", holdingNames.ToArray());
        }

        public long GetCompaniesAmount() 
        {
            var companiesAmount = (
                from holding in holdings
                from company in holding.Companies
                select company).Count();
            
            return companiesAmount;
        }

        public long GetAllUserAmount() 
        {
            var userAmount = (
                from holding in holdings
                from company in holding.Companies
                from user in company.Users
                select user).Count();

            return userAmount;
        }

        public List<string> GetAllCompaniesNames() 
        {
            var companiesNames = (
                from holding in holdings
                from company in holding.Companies
                select company.Name).ToList();

            return companiesNames;
        }

        public String GetAllCompaniesNamesAsString() 
        {
            return null;
        }

        public long GetAllUserAccountsAmount() 
        {
            return -1;
        }

        public string GetAllCurrencies() 
        {
            return null;
        }

        public long GetWomanAmount() 
        {
            return -1;
        }

        public decimal GetAccountAmountInPLN(Account account) 
        {
            return -1;
        }

        public decimal GetTotalCashInPLN(List<Account> accounts) 
        {
            return -1;
        }

        public List<String> GetOlderWoman(int age) 
        {
            return null;
        }

        public User? GetRichestWoman() 
        {
            return null;
        }

        public HashSet<String> GetFirstNCompany(int n) 
        {
            return null;
        }

        public AccountType? GetMostPopularAccountType() 
        {
            return null;
        }

        public Dictionary<string, List<User>> GetUserPerCompany() 
        {
            return null;
        }

        public Dictionary<string, List<string>> GetUserPerCompanyAsString() 
        {
            return null;
        }

        public Dictionary<bool, HashSet<string>> GetUserBySex() 
        {
            return null;
        }

        public Dictionary<string, Account> CreateAccountsDictionary() 
        {
            return null;
        }

        public string GetUserNames() 
        {
            return null;
        }

        public HashSet<User> GetUsers() 
        {
            return null;
        }


        public void ShowAllUser() 
        {
            throw new ArgumentException("not implemented yet");
        }

        public Dictionary<AccountType, decimal> GetMoneyOnAccounts() 
        {
            return null;
        }

        public int GetAgeSquaresSum() 
        {
            return -1;
        }

        public Dictionary<AccountType, Dictionary<User, decimal>> GetAccountUserMoneyInPLNMap()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Permit, List<User>> getUsersByTheyPermitsSorted()
        {
            throw new NotImplementedException();
        }
    }
}
