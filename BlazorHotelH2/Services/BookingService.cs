using DomainModels;
using Newtonsoft.Json;
using System.Text;

namespace BlazorHotelH2.Services
{
    public class BookingService
    {
        string bookingApi = "https://localhost:7036/api/Bookings";

        public async Task<bool> PostBookingAsync(Booking booking)
        {
            string jsonData = JsonConvert.SerializeObject(booking);

            HttpClient bookingSomething = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            StringContent data = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                response = await bookingSomething.PostAsync(bookingApi, data);

                return response.IsSuccessStatusCode;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
