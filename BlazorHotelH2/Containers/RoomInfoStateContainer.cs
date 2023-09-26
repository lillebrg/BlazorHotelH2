using DomainModels;

namespace BlazorHotelH2.Containers
{
    public class RoomInfoStateContainer
    {
        public Room Value { get; set; }
        public event Action OnStateChange;
        public void SetValue(Room value)
        {
            this.Value = value;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnStateChange?.Invoke();

    }
}
