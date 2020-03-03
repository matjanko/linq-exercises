using System;
using System.Collections.Generic;

namespace linq_exercises.src.domain 
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public List<Account> Accounts { get; set; }
        public List<Permit> Permits { get; set; }

        public partial class Builder {

            private string firstName;
            private string lastName;
            private Gender gender;
            private int age;
            private List<Account> accounts;
            private List<Permit> permits;

            public Builder FirstName(string firstName)
            {
                this.firstName = firstName;
                return this;
            }

            public Builder LastName(string lastName)
            {
                this.lastName = lastName;
                return this;
            }

            public Builder Gender(Gender gender)
            {
                this.gender = gender;
                return this;
            }

            public Builder Age(int age)
            {
                this.age = age;
                return this;
            }

            public Builder Accounts(List<Account> accounts)
            {
                this.accounts = accounts;
                return this;
            }

            public Builder Permits(List<Permit> permits)
            {
                this.permits = permits;
                return this;
            }

            public User Build() 
            {
                User user = new User();
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Gender = gender;
                user.Age = age;
                user.Accounts = accounts;
                user.Permits = permits;

                return user;
            }
        }
    }
}
