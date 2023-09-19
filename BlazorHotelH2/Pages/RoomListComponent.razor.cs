using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages
{
    partial class RoomListComponent
    {
        [Parameter]
        public Room Room { get; set; }
       

    }
}

