using System;
using System.Collections.Generic;
using LinqExercises.Mock;
using LinqExercises.Domain;

namespace LinqExercises.Logic
{
    public class WorkService : IWorkService
    {
        private readonly List<Holding> holdings;

        public WorkService()
        {
            this.holdings = new HoldingData().GetHoldings();
        }

        public long GetHoldingsWhereAreCompanies() {
            return -1;
        }

        public List<String> GetHoldingNames() 
        {
            return null;
        }

        public string GetHoldingNamesAsString() 
        {
            return null;
        }

        public long GetCompaniesAmount() 
        {
            return -1;
        }

        public long GetAllUserAmount() 
        {
            return -1;
        }

        public List<String> GetAllCompaniesNames() 
        {
            return null;
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
    }
}
