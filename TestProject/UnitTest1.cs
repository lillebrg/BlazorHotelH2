using BlazorHotelH2.Data;
using BlazorHotelH2.Models;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HotelH2Context HotelH2Context = new HotelH2Context();

            User user1 = new User()
            {
                userName = "testuser",
                password = "testpassword",
                email = "test@test.test",
                administrators = new Administrator(),
            };

            Administrator admin1 = new Administrator()
            {
                adminName = "testadmin"
            };
            user1.administrators = admin1;
            HotelH2Context.Users.Add(user1);
            HotelH2Context.SaveChanges();
        }
        [TestMethod]
        public void TestMethod2()
        {
            HotelH2Context HotelH2Context = new HotelH2Context();
            for (int i = 0; i < 20; i++)
            {
                User user = new User()
                {
                    userName = "testuser",
                    password = "testpassword",
                    email = "test@test.test",
                    customers = new Customer()
                };

                Customer admin1 = new Customer()
                {
                    customerName = "testCustomer",
                    address = "testStreet 32 6969 testcity",
                    bookings = new List<Booking>(),
                    creditCardInfo = "test123578654",
                    personCount = 2

                };
            
                user.customers = admin1;
                HotelH2Context.Users.Add(user);
                
            }
            HotelH2Context.SaveChanges();
        }
    }
}