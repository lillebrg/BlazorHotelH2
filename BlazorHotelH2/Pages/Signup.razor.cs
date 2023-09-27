using BlazorHotelH2.Services;
using DomainModels;

namespace BlazorHotelH2.Pages
{
    public partial class Signup
    {
        public Customer customer = new Customer();

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
            Console.WriteLine("done");
        }

}
}
