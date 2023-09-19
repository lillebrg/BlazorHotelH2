using DomainModels;
using Microsoft.AspNetCore.Components;

namespace BlazorHotelH2.Pages
{
    public partial class Login
    {
        [Parameter]
        public string SignupfirstName { get; set; }

        public Customer customer = new Customer();

        public void SubmitForm()
        {

        }
    }
}