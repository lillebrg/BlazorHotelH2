﻿using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class RoomsList
    {
        private RoomService roomService;
        private bool isElementVisible = true;

        public RoomsList()
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