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
        public void SubmitForm()
        {
            CustomerService customerService = new CustomerService();
            try
            {
                customerService.PostCustomerAsync(customer);
            }
            catch (Exception e)
            {

                throw e;
            }
            AccountSession session = new AccountSession();
            session.SetCustomer(customer);
            isPopupVisible = true;
        }
    }
}
