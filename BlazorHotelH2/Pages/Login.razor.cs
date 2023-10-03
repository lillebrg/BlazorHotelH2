using BlazorHotelH2;
using DomainModels;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using System.Text;
using System.Net.Http.Json;
using BlazorHotelH2.Shared.Utilities;

namespace BlazorHotelH2.Pages
{
    public partial class Login
    {
        public Customer customer = new Customer();
		public string errorMessage;
		public Customer? customeruser;
		public Admin? adminuser;
		


		private async Task HandleLogin()
		{
			if (!string.IsNullOrWhiteSpace(customer.Email) && !string.IsNullOrWhiteSpace(customer.Password))
			{
				string email = customer.Email;
				string password = customer.Password;

				try
				{
					// Admin authentication failed; let's try customer authentication.
					//customeruser = await Http.GetFromJsonAsync<Customer>($"https://localhost:7036/api/Customers/login/{email}/{password}");

					if (customeruser != null)
					{
						GlobalUserAuth.UserId = customeruser.Id;

						StateHasChanged();
						NavigationManager.NavigateTo("/");

						return;
					}
				}
				catch
				{
					errorMessage = "Invalid credentials. Please check your email and password.";
				}
			}
			else
			{
				// Handle empty input
				errorMessage = "Please enter your email and password.";
			}
		}

		public void Logout()
		{
			try
			{
				customeruser = null; // Clear the authenticated user
				adminuser = null; // Clear the authenticated user
				GlobalUserAuth.UserId = null;
				StateHasChanged();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception: {ex.Message}");
			}
		}
	}
}
