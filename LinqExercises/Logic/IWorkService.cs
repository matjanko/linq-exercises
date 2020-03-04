using System;
using System.Collections.Generic;
using LinqExercises.Domain;

namespace LinqExercises.Logic
{
    public interface IWorkService
    {
        ///
        /// Metoda zwraca liczbę holdingów w których jest przynajmniej jedna firma.
        ///
        long GetHoldingsWhereAreCompanies();

        ///
        /// Zwraca nazwy wszystkich holdingów pisane z małej litery w formie listy.
        ///
        List<String> GetHoldingNames();

        ///
        /// Zwraca nazwy wszystkich holdingów sklejone w jeden string. 
        ///
        string GetHoldingNamesAsString();

        ///
        /// Zwraca liczbę firm we wszystkich holdingach.
        ///
        long GetCompaniesAmount();

        ///
        /// Zwraca liczbę wszystkich pracowników we wszystkich firmach.
        ///
        long GetAllUserAmount();

        ///
        /// Zwraca listę wszystkich nazw firm w formie listy.
        ///
        List<String> GetAllCompaniesNames();

        ///
        /// Zwraca listę firm jako string gdzie poszczególne firmy są 
        /// oddzielone od siebie znakiem ", " i posortowane alfabetycznie.
        ///
        string GetAllCompaniesNamesAsString();

        ///
        /// Zwraca liczbę wszystkich rachunków, użytkowników we wszystkich firmach.
        ///
        long GetAllUserAccountsAmount();

        ///
        /// Zwraca listę wszystkich walut w jakich są rachunki jako string, 
        /// w którym wartości występują bez powtórzeń i są posortowane.
        ///
        string GetAllCurrencies();

        ///
        /// Zwraca liczbę kobiet we wszystkich firmach.
        ///
        long GetWomanAmount();

        ///
        /// Przelicza kwotę na rachunku na złotówki za pomocą kursu określonego w enum Currency. 
        /// Ustaw precyzje na 3 miejsca po przecinku.
        ///
        decimal GetAccountAmountInPLN(Account account);

        ///
        /// Przelicza kwotę na podanych rachunkach na złotówki za pomocą kursu 
        /// określonego w enum Currency  i sumuje ją.
        ///
        decimal GetTotalCashInPLN(List<Account> accounts);

        ///
        /// Metoda filtruje użytkowników starszych niż podany jako parametr wiek, 
        /// wyświetla ich na konsoli, odrzuca mężczyzn i zwraca ich imiona w formie listy.
        ///
        List<String> GetOlderWoman(int age);

        ///
        /// Wyszukuje najbogatsza kobietę i zwraca ja. 
        /// Metoda musi uzwględniać to że rachunki są w różnych walutach.
        ///
        User? GetRichestWoman();

        ///
        /// Zwraca nazwy pierwszych N firm. Kolejność nie ma znaczenia.
        ///
        HashSet<String> GetFirstNCompany(int n);

        ///
        /// Metoda zwraca jaki rodzaj rachunku jest najpopularniejszy.
        ///
        AccountType? GetMostPopularAccountType();

        ///
        /// Zwraca słownik firm, gdzie kluczem jest jej nazwa a wartością lista pracowników.
        ///
        Dictionary<string, List<User>> GetUserPerCompany();

        ///
        /// Zwraca słownik firm, gdzie kluczem jest jej nazwa a wartością lista 
        /// pracowników przechowywanych jako string składający się z imienia i nazwiska.
        ///
        Dictionary<string, List<string>> GetUserPerCompanyAsString();

        ///
        /// Zwraca słownik gdzie kluczem jest flaga mówiąca o tym czy mamy do czynienia z mężczyzną, czy z kobietą.
        /// Wartością jest natomiast zbiór nazwisk tych osób.
        ///
        Dictionary<bool, HashSet<string>> GetUserBySex();

        ///
        /// Zwraca słownik rachunków, gdzie kluczem jest numer rachunku, a wartością ten rachunek.
        ///
        Dictionary<string, Account> CreateAccountsDictionary();

        ///
        /// Zwraca listę wszystkich imion w postaci Stringa, 
        /// gdzie imiona oddzielone są spacją i nie zawierają powtórzeń.
        ///
        string GetUserNames();

        ///
        /// Zwraca zbiór wszystkich użytkowników. 
        /// Jeżeli jest ich więcej niż 10 to obcina ich ilość do 10.
        ///
        HashSet<User> GetUsers();

        ///
        /// Metoda wypisuje na ekranie wszystkich użytkowników (imie, nazwisko) posortowanych od z do a.
        ///
        void ShowAllUser();

        ///
        /// Zwraca mapę, gdzie kluczem jest typ rachunku a wartością kwota 
        /// wszystkich środków na rachunkach tego typu przeliczona na złotówki.
        ///
        Dictionary<AccountType, decimal> GetMoneyOnAccounts();

        ///
        /// Zwraca sumę kwadratów wieków wszystkich użytkowników.
        ///
        int GetAgeSquaresSum();

        ///
        /// Stwórz mapę gdzie kluczem jest typ rachunku a wartością mapa mężczyzn 
        /// posiadających ten rachunek, gdzie kluczem jest obiekt User a wartoscią 
        /// suma pieniędzy na rachunku danego typu przeliczona na złotkówki.
        ///
        Dictionary<AccountType, Dictionary<User, decimal>> GetAccountUserMoneyInPLNMap();

        ///
        /// Podziel wszystkich użytkowników po ich upoważnieniach, przygotuj mapę która gdzie 
        /// kluczem jest upoważnenie a wartością lista użytkowników, posortowana po ilości
        /// środków na koncie w kolejności od największej do najmniejszej ich ilości liczonej w złotówkach.
        ///
        Dictionary<Permit, List<User>> getUsersByTheyPermitsSorted();
    }
}