using DataAccessLayer.Data;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DomainModels;
using System.Runtime.Intrinsics.X86;
using System.Configuration;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

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
        public void TestMethod_AddStandardRooms()
        {
            HotelContext HotelContext = new HotelContext();
            for (int i = 0; i < 250; i++)
            {
                Picture picture = new Picture()
                {
                    PictureURL= "https://www.doylecollection.com/var/doyle/storage/images/media/doyle-redesign/images/hotels/dupont-circle/rooms-suites/superior-room-king/classic-king-bed-preview-image-revised-april-2016/181055-5-eng-US/classic-king-bed-preview-image-revised-april-2016_block_high_1_of_3.jpg"
                };
                Picture picture1 = new Picture()
                {
                    PictureURL = "https://milwaukeenns.org/wp-content/uploads/2019/08/hotel-bathroom.jpg"
                };
                Room standard = new Room()
                {
                    RoomType = "STANDARD",
                    Price = 600,
                    VacancyToday = true,
                    MaxPeople = 2,
                    Pictures = new List<Picture>()
                    { picture,
                      picture1
                    }

                };
                HotelContext.Room.Add(standard);
            }
            int result = HotelContext.SaveChanges();
            //Checks if the test ran as expected(if the test produces 34 entries but still works, this assert will tell you)
            Assert.AreEqual(750, result);
        }

        [TestMethod]
        public void TestMethod_AddPremiumRooms()
        {
            HotelContext HotelContext = new HotelContext();
            for (int i = 0; i < 150; i++)
            {
                Picture picture = new Picture()
                {
                    PictureURL = "https://cdn.loewshotels.com/loewshotels.com-2466770763/cms/cache/v2/5f5a6e0d12749.jpg/1920x1080/fit/80/86e685af18659ee9ecca35c465603812.jpg"
                };
                Picture picture1 = new Picture()
                {
                    PictureURL = "https://cdn2.hubspot.net/hubfs/4129352/hotel%20bathroom%20mayfair%20king%20suite.jpg"
                };
                Room standard = new Room()
                {
                    RoomType = "PREMIUM",
                    Price = 2000,
                    VacancyToday = true,
                    MaxPeople = 4,
                    Pictures = new List<Picture>()
                    { picture,
                      picture1
                    }

                };
                HotelContext.Room.Add(standard);
            }
            int result = HotelContext.SaveChanges();
            //Checks if the test ran as expected(if the test produces 34 entries but still works, this assert will tell you)
            Assert.AreEqual(450, result);
        }

        [TestMethod]
        public void TestMethod_AddDeluxeRooms()
        {
            HotelContext HotelContext = new HotelContext();
            for (int i = 0; i < 20; i++)
            {
                Picture picture = new Picture()
                {
                    PictureURL = "https://img.freepik.com/free-photo/luxury-bedroom-suite-resort-high-rise-hotel-with-working-table_105762-1783.jpg"
                };
                Picture picture1 = new Picture()
                {
                    PictureURL = "https://robbreport.com/wp-content/uploads/2022/05/Four-Bedroom-Lagoon-Pool-Villa-1.jpg"
                };
                Picture picture2 = new Picture()
                {
                    PictureURL = "https://theluxurytravelexpert.com/wp-content/uploads/2019/09/most-amazing-hotel-bathrooms-in-the-world-1.jpg"
                };
                Picture picture3 = new Picture()
                {
                    PictureURL = "https://hotelwithbathtub.com/wp-content/uploads/jacuzzi-room-hotel-tip-top-international-pune.jpeg"
                };
                Room standard = new Room()
                {
                    RoomType = "DELUXE",
                    Price = 4500,
                    VacancyToday = true,
                    MaxPeople = 3,
                    Pictures = new List<Picture>()
                    { picture,
                      picture1,
                      picture2,
                      picture3
                    }

                };
                HotelContext.Room.Add(standard);
            }
            int result = HotelContext.SaveChanges();
            //Checks if the test ran as expected(if the test produces 34 entries but still works, this assert will tell you)
            Assert.AreEqual(100, result);
        }
    }
}