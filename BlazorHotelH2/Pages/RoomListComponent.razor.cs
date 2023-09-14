using BlazorHotelH2.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages
{
    partial class RoomListComponent
    {
        [Parameter]
        public string FrontPicture { get; set; }
        [Parameter]
        public string RoomType { get; set; }
        [Parameter]
        public int Price { get; set; }
        [Parameter]
        public bool VacancyToday { get; set; }
        [Parameter]
        public int MaxPeople { get; set; }

    }
}

