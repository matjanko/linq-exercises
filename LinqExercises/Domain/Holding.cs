using System;
using System.Collections.Generic;

namespace LinqExercises.Domain
{
    public class Holding
    {
        public Holding(string name, List<Company> companies)
        {
            Name = name;
            Companies = companies;
        }

        public string Name { get; }
        public List<Company> Companies { get; }

        public override bool Equals(object obj)
        {
            return obj is Holding holding &&
                   Name == holding.Name &&
                   EqualityComparer<List<Company>>.Default.Equals(Companies, holding.Companies);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Companies);
        }
    }
}