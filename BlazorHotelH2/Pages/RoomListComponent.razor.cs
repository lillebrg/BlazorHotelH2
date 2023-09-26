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
        private void HandleButton()
        {
            RoomInfoStateContainer.SetValue(Room);
            navigationManager.NavigateTo("/roominfo");
        }
        public void Dispose()
        {
            RoomInfoStateContainer.OnStateChange -= StateHasChanged;
        }
    }
}

