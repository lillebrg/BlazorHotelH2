using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class RoomsInfo
    {
        private RoomService roomService;
        public RoomsInfo()
        {
            roomService = new RoomService();
        }
        public List<Room> AllRooms { get; set; } = new List<Room>();
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
