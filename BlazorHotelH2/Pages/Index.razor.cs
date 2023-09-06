using BlazorHotelH2.Data;
using BlazorHotelH2.Models;

namespace BlazorHotelH2.Pages
{
    public partial class Index
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("inside if");
            }
            Console.WriteLine("outside if");
            using (HotelH2Context context = new HotelH2Context())
            {
                var query = context.Users;

                //list skal være spicifik med hvad user indeholder(mangler adminid og customerid i users...)
                List<string> users = new List<string>();
                //users = query.ToList();
            }

        }
    }
}
