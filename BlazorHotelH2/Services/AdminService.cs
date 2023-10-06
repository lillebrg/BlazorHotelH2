using DomainModels;
using Newtonsoft.Json;

namespace BlazorHotelH2.Services
{
    public class AdminService
    {
        string adminApi = "https://localhost:7036/api/Admins";

        public async Task<Admin> GetAdminEmailAsync(string email, string password)
        {
            HttpClient adminClient = new HttpClient();

			adminApi = $"https://localhost:7036/api/Admins/{email}/{password}";


			HttpResponseMessage response = new HttpResponseMessage();

            Admin admin = new Admin();

            string jsonData = "";

            try
            {
                response = await adminClient.GetAsync(adminApi);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                jsonData = await response.Content.ReadAsStringAsync();
                admin = JsonConvert.DeserializeObject<Admin>(jsonData);
                if (admin != null)
                {
                    return admin;
                }
            }

            catch (Exception)
            {
                return null;
            }

            return null;
        }
    }
}
