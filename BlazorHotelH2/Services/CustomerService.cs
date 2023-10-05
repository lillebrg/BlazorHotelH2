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

        public async Task<Customer> GetCustomerEmailAsync(string email, string password)
        {
            HttpClient customerClient = new HttpClient();

            customerApi = $"https://localhost:7036/api/Customers/{email}/{password}";

            HttpResponseMessage response = new HttpResponseMessage();

            Customer customer = new Customer();

            string jsonData = "";

            try
            {
				response = await customerClient.GetAsync(customerApi);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                jsonData = await response.Content.ReadAsStringAsync();
                customer = JsonConvert.DeserializeObject<Customer>(jsonData);
                if (customer != null)
                {
                    return customer;
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
