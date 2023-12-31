﻿using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages.Rooms
{
    public partial class AdminRoomComponent
    {
        
        [Parameter]
        public Room Room { get; set; }
        private AdminRoomEditComponent EditModal { get; set; }
        private AdminRoomDeleteComponent DeleteModal { get; set; }

       
    }
}
