using System.Collections.Generic;
using System.Linq;
using linq_exercises.src.main.domain;

namespace linq_exercises.src.main.testdata
{
    public class UserData
    {
        private readonly AccountData accountData = new AccountData();

        public List<User> GetUsers() 
        {
            var accounts = accountData.GetAccounts();
            var users = new List<User>();

            users.Add(
                new User.Builder()
                    .FirstName("Adam")
                    .LastName("Wojcik")
                    .Age(17)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER 
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(0), 
                            accounts.ElementAt(1)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Mateusz")
                    .LastName("Kowalski")
                    .Age(33)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN 
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(2)
                        }
                    )
                    .Build());
            
            users.Add(
                new User.Builder()
                    .FirstName("Bartek")
                    .LastName("Pasibrzuch")
                    .Age(18)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(3)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Jan")
                    .LastName("Bazuka")
                    .Age(46)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(4),
                            accounts.ElementAt(5),
                            accounts.ElementAt(6)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Zosia")
                    .LastName("Psikuta")
                    .Age(67)
                    .Gender(Gender.Woman)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(7),
                            accounts.ElementAt(8),
                            accounts.ElementAt(9)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Magdalena")
                    .LastName("Warszawska")
                    .Age(33)
                    .Gender(Gender.Woman)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(10),
                            accounts.ElementAt(11)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Amadeusz")
                    .LastName("Mocarz")
                    .Age(29)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(12)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Filip")
                    .LastName("Flirciczart")
                    .Age(33)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(13)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Zenon")
                    .LastName("Kucowski")
                    .Age(21)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        {
                            Permit.DEPOSIT,
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Zenon")
                    .LastName("Biednapalka")
                    .Age(18)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                    )
                    .Accounts(
                        new List<Account>() 
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Mariusz")
                    .LastName("Dreh")
                    .Age(50)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(14)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Marcin")
                    .LastName("Marcinowicz")
                    .Age(37)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(15),
                            accounts.ElementAt(16),
                            accounts.ElementAt(17),
                            accounts.ElementAt(18),
                            accounts.ElementAt(19),
                            accounts.ElementAt(20),
                            accounts.ElementAt(21)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Jan")
                    .LastName("Nowicki")
                    .Age(45)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(22)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Kasia")
                    .LastName("Nawalka")
                    .Age(29)
                    .Gender(Gender.Woman)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(23),
                            accounts.ElementAt(24)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Marcin")
                    .LastName("Prawicowy")
                    .Age(29)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(25),
                            accounts.ElementAt(26)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Karol")
                    .LastName("Romanowicz")
                    .Age(64)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.LOAN
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(27),
                            accounts.ElementAt(28)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Marta")
                    .LastName("Wialkibuz")
                    .Age(33)
                    .Gender(Gender.Woman)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(29)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Patryk")
                    .LastName("Piwny")
                    .Age(28)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(30)
                        }
                    )
                    .Build());
            
            users.Add(
                new User.Builder()
                    .FirstName("Zenek")
                    .LastName("Jawowy")
                    .Age(22)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(31)
                        }
                    )
                    .Build());

            users.Add(
                new User.Builder()
                    .FirstName("Alfred")
                    .LastName("Pasibrzuch")
                    .Age(40)
                    .Gender(Gender.Man)
                    .Permits(
                        new List<Permit>() 
                        { 
                            Permit.DEPOSIT, 
                            Permit.TRANSFER,
                            Permit.LOAN,
                            Permit.ORDER_HISTORY
                        }
                    )
                    .Accounts(
                        new List<Account>() 
                        { 
                            accounts.ElementAt(32),
                            accounts.ElementAt(33),
                            accounts.ElementAt(34)
                        }
                    )
                    .Build());

            return users;
        }
    }
}