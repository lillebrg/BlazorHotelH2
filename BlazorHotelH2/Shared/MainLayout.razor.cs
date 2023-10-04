using BlazorHotelH2.Containers;
using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Shared
{
	public partial class MainLayout
	{
		AccountSession session = new AccountSession();
		Admin admin = new Admin();
		Customer customer = new Customer();
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			admin = session.GetAdmin();
			customer = session.GetCustomer();
			StateHasChanged();
		}

		public void LogOut()
		{
			session.forgetaccount();
		}
	}	
}
