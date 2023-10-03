using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages.AdminPages.Bookings
{
    public partial class AdminBookingList
    {
        private BookingService bookingService;
        private bool isElementVisible = true;
        public AdminBookingList()
        {
            bookingService = new BookingService();
        }
        public List<Booking> AllBookings { get; set; } = new List<Booking>();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                AllBookings = await bookingService.GetAllBookingsAsync();
                isElementVisible = !isElementVisible;
                StateHasChanged();
            }
        }
    }
}
