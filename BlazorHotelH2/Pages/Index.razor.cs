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
        }
    }
}
