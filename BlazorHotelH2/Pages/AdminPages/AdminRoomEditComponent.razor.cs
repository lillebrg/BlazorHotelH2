using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages.AdminPages
{
    public partial class AdminRoomEditComponent
    {

        [Parameter]
        public Room Room { get; set; }
        public Guid Guid = Guid.NewGuid();
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public string Id = "";
        public string MaxPeople = "";
        public string Price = "";
        public bool ShowBackdrop = false;


        public void Open()
        {
            ModalDisplay = "block;";
            ModalClass = "Show";
            ShowBackdrop = true;
            Id = Convert.ToString(Room.Id);
            MaxPeople = Convert.ToString(Room.MaxPeople);
            Price = Convert.ToString(Room.Price);
            StateHasChanged();
        }

        public void Close()
        {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
            StateHasChanged();
        }

        public void EditRoom()
        {
            Room.Id = Convert.ToInt32(Id);
        }
    }
}
