using Microsoft.AspNetCore.Mvc;

namespace final_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        
        [HttpPost("addloan")]
        public IActionResult AddLoan([FromBody] LoanRequestModel loanRequest)
        {
            
            return Ok(); 
        }

        
    }
}

