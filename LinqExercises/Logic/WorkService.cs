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
                from company in GetCompanies()
                select company).Count();
            
            return companiesAmount;
        }

        public long GetAllUserAmount() 
        {
            var userAmount = (
                from user in GetUsers()
                select user).Count();

            return userAmount;
        }

        public List<string> GetAllCompaniesNames() 
        {
            var companiesNames = (
                from company in GetCompanies()
                select company.Name).ToList();

            return companiesNames;
        }

        public string GetAllCompaniesNamesAsString() 
        {
            var companiesNames = (
                from company in GetCompanies()
                select company.Name).ToArray();
            
            Array.Sort(companiesNames, (x, y) => String.Compare(x, y)); 
            
            return String.Join(", ", companiesNames);
        }

        public long GetAllUserAccountsAmount() 
        {
            var accountsAmount = (
                from account in GetAccounts()
                select account).Count();
            
            return accountsAmount;
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

        public HashSet<User> GetUsersSet() 
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

        private IEnumerable<Company> GetCompanies()
        {
            return (from holding in holdings
                    from company in holding.Companies
                    select company).AsEnumerable();
        }

        private IEnumerable<User> GetUsers()
        {
            return (from company in GetCompanies()
                    from user in company.Users
                    select user).AsEnumerable();
        }

        private IEnumerable<Account> GetAccounts()
        {
            return (from user in GetUsers()
                    from account in user.Accounts
                    select account).AsEnumerable();
        }
    }
}
