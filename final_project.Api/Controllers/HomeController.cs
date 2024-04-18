using Final_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace final_project.Api.Controllers;

[Route("api")]

public class HomeController(FinalDbContext db) : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok(db.Loan.Where(x => x.UserID == 1));
        
    }
}