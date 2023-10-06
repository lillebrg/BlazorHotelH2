using DomainModels;

namespace BlazorHotelH2.Containers
{
    public static class AccountSession
    {
        public static Admin AdminSession {  get; set; }
        public static Customer CustomerSession { get; set; }
    }
}
