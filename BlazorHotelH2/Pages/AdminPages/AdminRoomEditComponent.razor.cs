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
        public bool ShowBackdrop = false;


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
    }
}
