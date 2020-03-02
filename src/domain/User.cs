using System;
using System.Collections.Generic;

namespace linq_exercises 
{
    public class User 
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Gender Gender { get; }
        public int Age { get; }

        public List<Account> Accounts { get; }
        public List<Permit> Permits { get; }
    }
}
