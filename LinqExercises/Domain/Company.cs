using System;
using System.Collections.Generic;

namespace LinqExercises.Domain
{
    public class Company
    {
        public Company(string name, List<User> users)
        {
            Name = name;
            Users = users;
        }

        public string Name { get; }
        public List<User> Users { get; }
    }
}