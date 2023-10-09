using BlazorHotelH2.Services;
using DomainModels;
using System.Diagnostics.Contracts;

namespace BlazorHotelH2.Pages
{
    public partial class Book
    {
        public bool ChooseDate { get; set; } = true;
        public bool ChooseAddress { get; set; } = false;    
        public bool ChooseCreditcard { get; set; } = false;
        public string zipcode { get; set; }
        public string cardnumber { get; set; }
        Customer inputCustomer = new Customer()
        {
            Address = new Address(),
            CreditCardInfo = new CreditCardInfo(),
        };
        Booking inputBooking = new Booking()
        {
            Room = new Room(),
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(1)
        };

        protected override void OnInitialized()
        {
            base.OnInitialized();
            inputBooking.Room = myStateContainer.Value;
        }

        public void DatesChosen()
        {
            ChooseDate = false;
            ChooseAddress = true;
        }
        public void AddressChosen()
        {
            ChooseAddress = false;
            ChooseCreditcard = true;
            inputCustomer.Address.ZipCode = Convert.ToInt32(zipcode);
        }
        public void CreditCardChosen()
        {
            inputCustomer.CreditCardInfo.CardNumber = Convert.ToInt32(cardnumber);
            Console.WriteLine("completed");
        }
        public void SubmitForm()
        {
            BookingService bookingService = new BookingService();

            try
            {
                bookingService.PostBookingAsync(inputBooking);
            }
            catch (Exception e)
            {

                throw e;
            }
            Console.WriteLine("done");
        }
    }
}
