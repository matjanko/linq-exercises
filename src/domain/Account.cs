using System;

namespace linq_exercises 
{
    public class Account
    {
        public string Number { get; }
        public AccountType AccountType { get; }

        public Currency Currency { get; }

        public Decimal Amount { get; }
    }
}