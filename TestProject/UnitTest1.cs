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
                customers = new Customer()
            };

            Administrator admin1 = new Administrator()
            {
                adminName = "testadmin"
            };
            user1.administrators = admin1;
            HotelH2Context.Users.Add(user1);
            HotelH2Context.SaveChanges();
        }
    }
}