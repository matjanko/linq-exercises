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
    }
}