using BlazorHotelH2.Containers;
using BlazorHotelH2.Services;
using DomainModels;
using System.Diagnostics.Contracts;

namespace BlazorHotelH2.Pages
{
    public partial class Book
    {
        BookingService bookingservice = new BookingService();
        private bool isPopupVisible = false;
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
            EndDate = DateTime.Now.AddDays(1),
            Customer = AccountSession.CustomerSession
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
            inputCustomer.CreditCardInfo.ExpirationDate = DateTime.Now;
        }
        public void CreditCardChosen()
        {
            inputCustomer.CreditCardInfo.CardNumber = Convert.ToInt32(cardnumber);

            try
            {
                bookingservice.PostBookingAsync(inputBooking);
            }
            catch (Exception e)
            {

                isPopupVisible = false;
            }
            isPopupVisible = true;
        }
    }
}
