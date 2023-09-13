using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    partial class RoomListComponent
    {
        private RoomService roomService;
        public RoomListComponent()
        {
            roomService = new RoomService();
        }
        public List<Room> AllRooms { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {  
                AllRooms = await roomService.GetAllRoomsAsync();
                StateHasChanged();
            }
        }
    }
}

