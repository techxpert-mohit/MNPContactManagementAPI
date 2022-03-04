using Microsoft.AspNetCore.Mvc;

namespace MNPContactManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly DataContext _context;
        public CompanyController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetContacts()
        {
            return Ok(await _context.Companies.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Company>>> AddContact(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return Ok(await _context.Companies.ToListAsync());
        }
    }
}
