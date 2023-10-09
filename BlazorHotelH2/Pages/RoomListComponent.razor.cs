using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;

namespace BlazorHotelH2.Pages
{
    partial class RoomListComponent
    {
        [Parameter]
        public Room Room { get; set; }
        protected override void OnInitialized()
        {
            RoomInfoStateContainer.OnStateChange += StateHasChanged;
        }
        private void GoToDetails()
        {
            RoomInfoStateContainer.SetValue(Room);
            navigationManager.NavigateTo("/roominfo");
        }
        private void GoToBooking()
        {
            RoomInfoStateContainer.SetValue(Room);
            navigationManager.NavigateTo("/booking");
        }
        public void Dispose()
        {
            RoomInfoStateContainer.OnStateChange -= StateHasChanged;
        }
    }
}

