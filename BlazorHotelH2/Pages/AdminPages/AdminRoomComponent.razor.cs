using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages
{
    public partial class AdminRoomComponent
    {
        [Parameter]
        public Room Room { get; set; }
        private AdminRoomEditComponent Modal { get; set; }
    }
}
