using NUnit.Framework;
using LinqExercises.Logic;
using System.Collections.Generic;
using LinqExercises.Domain;
using System;

namespace LinqExercises.Tests
{
    [TestFixture]
    public class WorkServiceTest
    {
        private IWorkService workService;


        [SetUp]
        public void Setup()
        {
            workService = new WorkService();
        }

        [Test]
        public void Should_Return_Amount_Of_Holding_Where_Is_At_Least_One_Company()
        {
            //when
            long result = workService.GetHoldingsWhereAreCompanies();
            
            //then
            Assert.That(3, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_Lower_Case_Name_Of_All_Holdings() 
        {
            //given
            List<string> expected = new List<string>() 
            { 
                "coca-cola",
                "nestle",
                "pepsico" 
            };
            
            //when
            List<string> result = workService.GetHoldingNames();
            
            //then
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_Names_Of_All_Holding_In_String()
        {
            //when
            string result = workService.GetHoldingNamesAsString();
            
            //then
            Assert.That("Coca-cola, Nestle, Pepsico", Is.EqualTo(result));
        }

        [Test]
        public void Should_Count_Companies_In_Holdings() 
        {
            //when
            long result = workService.GetCompaniesAmount();
            
            //then
            Assert.That(8, Is.EqualTo(result));
        }

        [Test]
        public void Should_Count_All_Users_In_All_Companies() 
        {
            //when
            long result = workService.GetAllUserAmount();
            
            //then
            Assert.That(20, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_All_Companies_Name() 
        {
            //given
            List<string> expected = new List<string>() 
            {
                "Fanta",
                "Sprite", 
                "Nescafe", 
                "Gerber", 
                "Nestea", 
                "Lays", 
                "Pepsi", 
                "Mirinda"
            };
            
            //when
            List<string> result = workService.GetAllCompaniesNames();
            
            //then
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_All_Companies_Names_As_String()
        {
            //given
            string expected = "Fanta, Gerber, Lays, Mirinda, Nescafe, Nestea, Pepsi, Sprite";
            
            //when
            string result = workService.GetAllCompaniesNamesAsString();

            //then
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_How_Much_Account_Have_Users() 
        {
            //when
            long result = workService.GetAllUserAccountsAmount();
            
            //then
            Assert.That(35, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_String_Of_All_Currencies()
        {
            //given
            string expected = "CHF, EUR, PLN, USD";
            
            //when
            string result = workService.GetAllCurrencies();

            //then
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_How_Many_Women_Are_In_Companies() 
        {
            //when
            long result = workService.GetWomanAmount();

            //then
            Assert.That(4, Is.EqualTo(result));
        }

        [Test]
        public void Should_Calculate_Amount_In_PLN()
        {
            //given
            var account = new Account("1234", AccountType.LO1, Currency.USD, 1m);

            //when
            decimal amount = workService.GetAccountAmountInPLN(account);

            //then
            Assert.That(3.72m, Is.EqualTo(amount));
        }

        [Test]
        public void Should_Get_Total_CAsh_PLN_Correctly_Sum()
        {
            //given
            List<Account> accounts = new List<Account>()
            {
                new Account("1234", AccountType.LO1, Currency.PLN, 150m),
                new Account("2345", AccountType.LO1, Currency.USD, 50),
                new Account("3456", AccountType.LO1, Currency.PLN, 300m),
            };
            //when
            decimal result = workService.GetTotalCashInPLN(accounts);

            //then
            Assert.That(636m, Is.EqualTo(result));
        }

        [Test]
        public void Should_Return_Woman_Which_Are_Older_Than_50() 
        {
            //given
            List<string> experted = new List<string>() { "Zosia" };
            
            //when
            List<string> result = workService.GetOlderWoman(50);
            
            //then
            Assert.That(experted, Is.EquivalentTo(result));
        }

        [Test]
        public void Should_Get_Richest_Woman()
        {
            //when
            User? result = workService.GetRichestWoman();

            //then
            Assert.That("Zosia", Is.EqualTo(result.FirstName));
            Assert.That("Psikuta", Is.EqualTo(result.LastName));
        }

    }
}