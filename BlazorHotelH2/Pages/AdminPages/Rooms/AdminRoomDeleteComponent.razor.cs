using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages.Rooms
{
    public partial class AdminRoomDeleteComponent
    {
        [Parameter]
        public Room Room { get; set; }
        public Guid Guid = Guid.NewGuid();
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public bool ShowBackdrop = false;
        private bool isPopupVisible = false;
        public string errormessage = "";
        private RoomService roomService = new RoomService();


        public void Open()
        {
            ModalDisplay = "block;";
            ModalClass = "Show";
            ShowBackdrop = true;
            StateHasChanged();
        }

        public void Close()
        {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
            StateHasChanged();
        }
        public async void DeleteRoom()
        {
            try
            {
                isPopupVisible = await roomService.DeleteRoomAsync(Room);
            }
            catch (Exception)
            {

                errormessage = "Something went wrong. try again!";
                StateHasChanged();
            }
        }
    }
}
