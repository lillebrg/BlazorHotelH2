using DomainModels;
using Newtonsoft.Json;
using System.Text;

namespace BlazorHotelH2.Services
{
    public class BookingService
    {
        string bookingApi = "https://localhost:7036/api/Bookings";
        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            HttpClient bookingClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            List<Booking> allBooking = new List<Booking>();

            string jsonData = "";

            try
            {
                response = await bookingClient.GetAsync(bookingApi);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                jsonData = await response.Content.ReadAsStringAsync();
                allBooking = JsonConvert.DeserializeObject<List<Booking>>(jsonData);
                if (allBooking.Count > 0)
                {
                    return allBooking;
                }
            }

            catch (Exception)
            {
                return null;
            }

            return null;
        }

        public async Task<bool> PostBookingAsync(Booking booking)
        {
            string jsonData = JsonConvert.SerializeObject(booking);

            HttpClient bookingClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            StringContent data = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                response = await bookingClient.PostAsync(bookingApi, data);

                return response.IsSuccessStatusCode;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
