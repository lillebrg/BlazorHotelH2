using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class Book
    {
        public Booking booking = new Booking();
        public void SubmitForm()
        {
            BookingService bookingService = new BookingService();

            try
            {
                bookingService.PostBookingAsync(booking);
            }
            catch (Exception e)
            {

                throw e;
            }
            Console.WriteLine("done");
        }
    }
}
