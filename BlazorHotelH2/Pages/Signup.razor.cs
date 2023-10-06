using BlazorHotelH2.Containers;
using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorHotelH2.Pages
{
    
    public partial class Signup
    {
        
        public Customer customer = new Customer();
        private bool isPopupVisible = false;
        public string errormessage = "";
        public void SubmitForm()
        {
            CustomerService customerService = new CustomerService();
            try
            {
                customerService.PostCustomerAsync(customer);
            }
            catch (Exception e)
            {

                errormessage = "An error has occured, Try again!";
            }
            AccountSession.CustomerSession = customer;
            isPopupVisible = true;
        }
    }
}
