using LoanQuotion.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanQuotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        public LoanRepository _loanRepository { get; set; }
        public LoanController(IConfiguration configuration)
        {
            _loanRepository = new LoanRepository(configuration);
        }

        [HttpGet]
        public IActionResult getLoan()
        {
            var loan = _loanRepository.getAllLoan();

            
            return Ok(new { loan });
            
        }

    }
}
