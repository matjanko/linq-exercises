using System;

namespace LinqExercises.Domain
{
    public class Account
    {
        public Account(string number, AccountType type, Currency currency, decimal amount)
        {
            Number = number;
            AccountType = type;
            Currency = currency;
            Amount = amount;
        }

        public string Number { get; }
        public AccountType AccountType { get; }

        public Currency Currency { get; }

        public decimal Amount { get; }
    }
}