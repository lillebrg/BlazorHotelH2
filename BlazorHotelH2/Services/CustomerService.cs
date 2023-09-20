using static System.Net.WebRequestMethods;
using BlazorHotelH2.Pages;
using DomainModels;
using Newtonsoft.Json;
using Microsoft.Identity.Client;

namespace BlazorHotelH2.Services
{
    public class CustomerService
    {
        //string customerApi = https://localhost:7036/api/Customers

        public async Task<bool> PostCustomerAsync()
        {
            HttpClient customerClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

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

            return false;
        }
    }
}
