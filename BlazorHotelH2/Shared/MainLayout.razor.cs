using BlazorHotelH2.Containers;
using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Shared
{
	public partial class MainLayout
	{
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{

			if (AccountSession.CustomerSession != null || AccountSession.AdminSession != null)
			{
				StateHasChanged();
			}

		}

		public void LogOut()
		{
			AccountSession.CustomerSession = null;
			AccountSession.AdminSession = null;
			StateHasChanged();
		}
	}	
}
