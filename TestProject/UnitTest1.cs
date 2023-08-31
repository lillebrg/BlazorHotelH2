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
            HotelH2Context DBcontext = new HotelH2Context();
            //hello
            User user1 = new User()
            {
                userName = "testuser",
                password = "testpassword",
                email = "test@test.test",
                administrators = new List<Administrator>(),
                customers = new List<Customer>()
            };

            Administrator admin1 = new Administrator()
            {
                adminName = "testadmin"
            };
            user1.administrators.Add(admin1);
            DBcontext.Users.Add(user1);
            DBcontext.SaveChanges();
        }
    }
}