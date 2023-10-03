using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages.Bookings
{
    public partial class AdminBookingEditComponent
    {
        [Parameter]
        public Booking Booking { get; set; }
        public Guid Guid = Guid.NewGuid();
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public string BId = "";
        public string RId = "";

        public bool ShowBackdrop = false;


        public void Open()
        {
            ModalDisplay = "block;";
            ModalClass = "Show";
            ShowBackdrop = true;
            BId = Convert.ToString(Booking.Id);
            RId = Convert.ToString(Booking.Room.Id);
            StateHasChanged();
        }

        public void Close()
        {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
            StateHasChanged();
        }

        public void EditBooking()
        {
            Booking.Id = Convert.ToInt32(BId);
        }
    }
}
