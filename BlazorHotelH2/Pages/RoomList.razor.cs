using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class RoomList
    {
        private RoomService roomService;
        private bool isElementVisible = true;

        public RoomList()
        {
            roomService = new RoomService();
        }
        public List<Room> AllRooms { get; set; } = new List<Room>();
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                AllRooms = await roomService.GetAllRoomsAsync();
                isElementVisible = !isElementVisible;
                StateHasChanged();
            }
        }
    }
}
