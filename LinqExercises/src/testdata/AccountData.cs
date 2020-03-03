using System;
using System.Collections.Generic;
using linq_exercises.src.domain;

namespace linq_exercises.src.testdata
{
    public class AccountData
    {
        public List<Account> GetAccounts() 
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account(
                "6754", 
                AccountType.LO1, 
                Currency.PLN, 
                (decimal) 10.50));

            accounts.Add(new Account(
                "1178", 
                AccountType.ROR1, 
                Currency.USD, 
                (decimal) 999.50));

            accounts.Add(new Account(
                "8967", 
                AccountType.ROR1, 
                Currency.EUR, 
                (decimal) 1000));

            accounts.Add(new Account(
                "112221", 
                AccountType.ROR1, 
                Currency.PLN, 
                (decimal) 1667.22));

            accounts.Add(new Account(
                "1234", 
                AccountType.ROR1, 
                Currency.EUR, 
                (decimal) 1888822.1));
                
            accounts.Add(new Account(
                "2346", 
                AccountType.ROR1, 
                Currency.PLN, 
                (decimal) 8236626.12));

            accounts.Add(new Account(
                "7676", 
                AccountType.ROR1, 
                Currency.EUR, 
                (decimal) 1230));

            accounts.Add(new Account(
                "0192", 
                AccountType.ROR1, 
                Currency.PLN, 
                (decimal) 88890.0));

            accounts.Add(new Account(
                "8474", 
                AccountType.ROR1, 
                Currency.CHF, 
                (decimal) 10000.60));

            accounts.Add(new Account(
                "3892", 
                AccountType.ROR1, 
                Currency.EUR, 
                (decimal) 70998.8));

            accounts.Add(new Account(
                "65423", 
                AccountType.ROR1, 
                Currency.PLN, 
                (decimal) 800.99));

            accounts.Add(new Account(
                "87631", 
                AccountType.RO2, 
                Currency.CHF, 
                (decimal) 100));

            accounts.Add(new Account(
                "1235478", 
                AccountType.LO1, 
                Currency.PLN, 
                (decimal) 1));

            accounts.Add(new Account(
                "72446", 
                AccountType.RO1, 
                Currency.CHF, 
                (decimal) 0.01));

            accounts.Add(new Account(
                "90753", 
                AccountType.RO1, 
                Currency.CHF, 
                (decimal) 0));

            accounts.Add(new Account(
                "865423", 
                AccountType.RO2, 
                Currency.CHF, 
                (decimal) 0));

            accounts.Add(new Account(
                "9612541", 
                AccountType.LO2, 
                Currency.USD, 
                (decimal) 23500.86));

            accounts.Add(new Account(
                "971561", 
                AccountType.RO1, 
                Currency.USD, 
                (decimal) 9999));

            accounts.Add(new Account(
                "97156221", 
                AccountType.LO2, 
                Currency.CHF, 
                (decimal) 10));

            accounts.Add(new Account(
                "867151", 
                AccountType.RO1, 
                Currency.PLN, 
                (decimal) 109823.00));

            accounts.Add(new Account(
                "862252", 
                AccountType.RO1, 
                Currency.CHF, 
                (decimal) 123771));

            accounts.Add(new Account(
                "872562", 
                AccountType.RO2, 
                Currency.PLN, 
                (decimal) 1234));

            accounts.Add(new Account(
                "86252", 
                AccountType.LO1, 
                Currency.PLN, 
                (decimal) 7332));

            accounts.Add(new Account(
                "34563", 
                AccountType.RO2, 
                Currency.PLN, 
                (decimal) 2346));

            accounts.Add(new Account(
                "1122", 
                AccountType.RO2, 
                Currency.USD, 
                (decimal) 100));

            accounts.Add(new Account(
                "62222", 
                AccountType.RO1, 
                Currency.PLN, 
                (decimal) 1009));

            accounts.Add(new Account(
                "73344", 
                AccountType.RO2, 
                Currency.PLN, 
                (decimal) 0));

            accounts.Add(new Account(
                "8723212", 
                AccountType.LO1, 
                Currency.USD, 
                (decimal) 2435));

            accounts.Add(new Account(
                "3457117", 
                AccountType.RO2, 
                Currency.PLN, 
                (decimal) 10000984));

            accounts.Add(new Account(
                "45218", 
                AccountType.ROR2, 
                Currency.CHF, 
                (decimal) 108987.0));

            accounts.Add(new Account(
                "24578", 
                AccountType.LO1, 
                Currency.CHF, 
                (decimal) 13873));

            accounts.Add(new Account(
                "0000064", 
                AccountType.LO1, 
                Currency.USD, 
                (decimal) 9766));

            accounts.Add(new Account(
                "2322255", 
                AccountType.ROR2, 
                Currency.CHF, 
                (decimal) 1000));

            accounts.Add(new Account(
                "666622", 
                AccountType.ROR2, 
                Currency.CHF, 
                (decimal) 287));

            accounts.Add(new Account(
                "998292", 
                AccountType.ROR2, 
                Currency.CHF, 
                (decimal) 1467));

            accounts.Add(new Account(
                "938383", 
                AccountType.LO1, 
                Currency.EUR, 
                (decimal) 1600));

            accounts.Add(new Account(
                "2018543", 
                AccountType.LO1, 
                Currency.PLN, 
                (decimal) 23000.86));

            return accounts;
        }
    }
}