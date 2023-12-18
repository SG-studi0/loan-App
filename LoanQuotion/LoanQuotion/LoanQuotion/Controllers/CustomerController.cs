using LoanQuotion.DataAccessLayer;
using LoanQuotion.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace LoanQuotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        public CustomerRepository _customerRepository { get; set; }
        public CustomerController(IConfiguration configuration)
        {
            _customerRepository = new CustomerRepository(configuration);
        }

        [HttpPost("")]
        public IActionResult createCustomers(Customer customer)
        {
            var customers = _customerRepository.AddCustomer(customer);
            return Ok(new { customers});
        }

        
    }
}
