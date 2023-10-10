using Microsoft.AspNetCore.Mvc;
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

		// GET: api/Customers/5
		[HttpGet("{email}/{password}")]
		public async Task<ActionResult<Customer>> GetCustomerEmail(string email, string password)
		{
            var customer = await repoCustomer.GetCustomerAsync();
			if (customer == null)
			{
				return NotFound();
			}

            customer = customer.Where(item => item.Email == email && item.Password == password);
            if (customer.Count() != 1 && customer != null)
            {
                return NotFound();
            }

            return customer.First();
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
