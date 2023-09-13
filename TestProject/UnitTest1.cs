using DataAccessLayer.Data;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DomainModels;
using System.Runtime.Intrinsics.X86;
using System.Configuration;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HotelContext HotelContext = new HotelContext();
            for (int i = 0; i < 35; i++)
            {

                Address cu1Address = new Address()
                {
                    Country = "Denmark",
                    address = $"ImHomeless{i}",
                    ZipCode = 6969,
                    City = "Somewhere(LA)"
                };
                CreditCardInfo cu1CreditCardInfo = new CreditCardInfo()
                {
                    NameOnCard = $"IAmABrokienr.{i}",
                    CardNumber = i * 3847,
                    ExpirationDate = DateTime.Now
                };
                Customer customer1 = new Customer()
                {
                    UserName = $"testuser{i}",
                    Email = $"test{i}@test.test",
                    Password = $"testpassword{i}",
                    PhoneNumber = $"{i}{i}{i}{i}{i}{i}{i}{i}",
                    PersonCount = i,
                    Address = cu1Address,
                    CreditCardInfo = cu1CreditCardInfo
                };
                HotelContext.Customer.Add(customer1);
            }
            int result = HotelContext.SaveChanges();
            //Checks if the test ran as expected(if the test produces 34 entries but still works, this assert will tell you)
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}