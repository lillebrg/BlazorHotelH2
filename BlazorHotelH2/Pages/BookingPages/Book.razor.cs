using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages.BookingPages
{
    public partial class Book
    {
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
