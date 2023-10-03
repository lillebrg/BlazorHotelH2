using DomainModels;

namespace BlazorHotelH2.Containers
{
    public class AccountSession
    {
        public Admin AdminSession {  get; set; }
        public Customer CustomerSession { get; set; }

        public void SetAdmin(Admin admin)
        {
            AdminSession = admin;
        }
        public void SetCustomer(Customer customer)
        {
            CustomerSession = customer;
        }
        public Admin GetAdmin()
        {
            return AdminSession;
        }
        public Customer GetCustomer()
        {
            return CustomerSession;
        }
        public void forgetaccount()
        {
            AdminSession = new Admin();
            CustomerSession = new Customer();
        }
    }
}
