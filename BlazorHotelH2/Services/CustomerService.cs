using static System.Net.WebRequestMethods;
using BlazorHotelH2.Pages;
using DomainModels;
using Newtonsoft.Json;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Localization;
using System.Text;

namespace BlazorHotelH2.Services
{
    public class CustomerService
    {
        string customerApi = "https://localhost:7036/api/Customers";

        public async Task<bool> PostCustomerAsync(Customer customer)
        {
            string jsonData = JsonConvert.SerializeObject(customer);

            HttpClient customerClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            StringContent data = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                //response = await customerClient.GetAsync(customerApi);
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
