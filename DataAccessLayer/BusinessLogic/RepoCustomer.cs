using DataAccessLayer.Controllers;
using DataAccessLayer.Data;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.BusinessLogic
{
    public class RepoCustomer
    {
        private readonly HotelContext _context;

        public RepoCustomer()
        {
            _context = new HotelContext();
        }

        public async Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            var customer = await _context.Customer.FindAsync(id);

            return customer;
        }

        public async Task<Customer> PutCustomerAsync(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return null;
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return customer;
        }

        public async Task<Customer> PostCustomerAsync(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return null;
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        private bool CustomerExists(int id)
        {
            return (_context.Customer?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
