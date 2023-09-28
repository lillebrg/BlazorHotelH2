using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Data;
using DomainModels;
using DataAccessLayer.BusinessLogic;

namespace DataAccessLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //seperation of concern
        private readonly RepoCustomer repoCustomer;

        public CustomersController()
        {
            repoCustomer = new RepoCustomer();
        }
        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            IEnumerable<Customer> customerList = await repoCustomer.GetCustomerAsync();
            if (customerList != null)
            {
                return Ok(customerList);
            }
            return NotFound();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            Customer customer = (Customer)await repoCustomer.GetCustomerAsync(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound();
        }

        //PUT: api/Customers/5
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            await repoCustomer.PutCustomerAsync(id, customer);
            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            await repoCustomer.PostCustomerAsync(customer);
            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (await repoCustomer.DeleteCustomerAsync(id) == null)
            {
                return NotFound();
            } 
            return NoContent();
        }

        
    }
}
