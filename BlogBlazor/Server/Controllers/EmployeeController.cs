using BlogBlazor.Shared.Data;
using BlogBlazor.Shared.ModelEF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly MasterContext _context;
        public EmployeeController(MasterContext context)
        {
            _context = context;
        }

        // GET: api/<Employee>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

       
    }
}
