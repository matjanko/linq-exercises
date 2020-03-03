using NUnit.Framework;
using LinqExercises.Logic;

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
            long result = workService.GetHoldingsWhereAreCompanies();
            Assert.That(3, Is.EqualTo(result));
        }
    }
}