using BlazorHotelH2.Containers;
using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Shared
{
	public partial class MainLayout
	{
		AccountSession session = new AccountSession();

		
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{

			if (session.CustomerSession != null && session.AdminSession != null)
			{
				StateHasChanged();
			}
			
		}

		public void LogOut()
		{
			session.CustomerSession = new Customer();
			session.AdminSession = new Admin();
		}
	}	
}
