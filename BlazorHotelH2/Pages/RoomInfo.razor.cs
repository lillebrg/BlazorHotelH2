using DomainModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHotelH2.Pages
{
    public partial class RoomInfo
    {
        private Room room;
        private int currentIndex = 0;
        private bool showArrows = false;

        private void NextImage()
        {
            currentIndex = (currentIndex + 1) % room.Pictures.Count;
        }

        private void PreviousImage()
        {
            currentIndex = (currentIndex - 1 + room.Pictures.Count) % room.Pictures.Count;
        }
        private void ToggleArrows()
        {
            showArrows = !showArrows;
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            room = myStateContainer.Value;
        }
    }
}
