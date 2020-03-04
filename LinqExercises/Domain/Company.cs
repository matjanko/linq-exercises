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

        public override bool Equals(object obj)
        {
            return obj is Company company &&
                   Name == company.Name &&
                   EqualityComparer<List<User>>.Default.Equals(Users, company.Users);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Users);
        }
    }
}