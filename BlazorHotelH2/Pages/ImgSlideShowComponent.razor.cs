using BlazorHotelH2.Services;
using DomainModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorHotelH2.Pages
{
    public partial class ImgSlideShowComponent
    {
        [Parameter]
        public List<Picture> Pictures { get; set; }

        //[Inject]
        //IJSRuntime runtime {  get; set; }
        //IJSObjectReference? module;

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        module = await runtime.InvokeAsync<IJSObjectReference>("import", "./Pages/ImgSlideShowComponent.razor.js");
        //        await module.InvokeVoidAsync("showSlides", 1);
        //    }
        //}
        //public async void PlusSlides(int n)
        //{
        //    await module.InvokeVoidAsync("plusSlides", n);
        //}
    }
}
