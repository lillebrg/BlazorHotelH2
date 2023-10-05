using DomainModels;

namespace BlazorHotelH2.Containers
{
    public class AccountSession
    {
        public Admin AdminSession {  get; set; }
        public Customer CustomerSession { get; set; }
    }
}
