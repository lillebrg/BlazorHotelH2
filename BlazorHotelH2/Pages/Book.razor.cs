using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class Book
    {
        public Input input = new()
        {
            inputBooking = new Booking()
            {
                Room = new Room(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1)
            },
        };

        public class Input
        {
            public Booking inputBooking;
            public uint typeId;
        }

        public void SubmitForm()
        {
            BookingService bookingService = new BookingService();

            try
            {
                bookingService.PostBookingAsync(input.inputBooking);
            }
            catch (Exception e)
            {

                throw e;
            }
            Console.WriteLine("done");
        }
    }
}
