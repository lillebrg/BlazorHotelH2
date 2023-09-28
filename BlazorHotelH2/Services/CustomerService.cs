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
        //remember to change the call method to the specified CRUD operation you want to use
        string customerApi = "https://localhost:7036/api/Customers";

        public async Task<bool> PostCustomerAsync(Customer customer)
        {
            string jsonData = JsonConvert.SerializeObject(customer);

            HttpClient customerClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            StringContent data = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                response = await customerClient.PostAsync(customerApi, data);

               return response.IsSuccessStatusCode;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
