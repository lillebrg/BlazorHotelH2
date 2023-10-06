using BlazorHotelH2;
using DomainModels;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using System.Text;
using System.Net.Http.Json;
using BlazorHotelH2.Services;
using BlazorHotelH2.Containers;

namespace BlazorHotelH2.Pages
{
    public partial class Login
    {
		public Customer customer = new Customer();
		public string errorMessage = "";
		public Customer? customeruser;
		public Admin? adminuser;
		
		private async Task HandleLogin()
		{
			if (!string.IsNullOrWhiteSpace(customer.Email) && !string.IsNullOrWhiteSpace(customer.Password))
			{
				string email = customer.Email;
				string password = customer.Password;


					CustomerService customerService = new CustomerService();
					Customer validCustomer = new Customer();
                    validCustomer = await customerService.GetCustomerEmailAsync(email, password);

					if (validCustomer != null)
					{
						AccountSession.CustomerSession = validCustomer;
						NavigationManager.NavigateTo("/");
					}
					else
					{
						AdminService adminService = new AdminService();
						Admin validAdmin = new Admin();
						validAdmin = await adminService.GetAdminEmailAsync(email, password);
						if (validAdmin != null)
						{
							AccountSession.AdminSession = validAdmin;
							NavigationManager.NavigateTo("/");
						}
						errorMessage = "Invalid credentials. Please check your email and password.";
						StateHasChanged();
					}
			}
			else
			{
				// Handle empty input
				errorMessage = "Please enter your email and password.";
				StateHasChanged();
			}
		}

		public void Logout()
		{
			try
			{
				AccountSession.CustomerSession = null;
				AccountSession.AdminSession = null;
				StateHasChanged();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception: {ex.Message}");
			}
		}
	}
}
