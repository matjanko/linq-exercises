using NUnit.Framework;
using LinqExercises.Logic;
using System.Collections.Generic;

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
    }
}