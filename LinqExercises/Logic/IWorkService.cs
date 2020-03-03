using System;
using System.Collections.Generic;
using LinqExercises.Domain;

namespace LinqExercises.Logic
{
    public interface IWorkService
    {
        long GetHoldingsWhereAreCompanies();

        List<String> GetHoldingNames();

        string GetHoldingNamesAsString();

        long GetCompaniesAmount();

        long GetAllUserAmount();

        List<String> GetAllCompaniesNames();

        string GetAllCompaniesNamesAsString();

        long GetAllUserAccountsAmount();

        string GetAllCurrencies();

        long GetWomanAmount();

        decimal GetAccountAmountInPLN(Account account);

        decimal GetTotalCashInPLN(List<Account> accounts);

        List<String> GetOlderWoman(int age);

        User? GetRichestWoman();

        HashSet<String> GetFirstNCompany(int n);

        AccountType? GetMostPopularAccountType();

        Dictionary<string, List<User>> GetUserPerCompany();

        Dictionary<string, List<string>> GetUserPerCompanyAsString();

        Dictionary<bool, HashSet<string>> GetUserBySex();

        Dictionary<string, Account> CreateAccountsDictionary();

        string GetUserNames();

        HashSet<User> GetUsers();

        void ShowAllUser();

        Dictionary<AccountType, decimal> GetMoneyOnAccounts();

        int GetAgeSquaresSum();
    }
}