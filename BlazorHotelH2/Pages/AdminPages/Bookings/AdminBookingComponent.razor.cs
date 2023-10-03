using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages.Bookings
{
    public partial class AdminBookingComponent
    {
        [Parameter]
        public Booking Booking { get; set; }
        private AdminBookingEditComponent Modal { get; set; }
    }
}
