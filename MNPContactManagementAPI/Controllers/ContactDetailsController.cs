using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MNPContactManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        private readonly DataContext _context;
        public ContactDetailsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ContactDetails>>> GetContacts()
        {
            return Ok(await _context.ContactDetails.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDetails>> GetContact(int id)
        {
            var contact = await _context.ContactDetails.FindAsync(id);
            if (contact == null)
                return BadRequest("Contact not found");
            return Ok(contact);
        }

        [HttpPost]
        public async Task<ActionResult<List<ContactDetails>>> AddContact(ContactDetails contact)
        {
            _context.ContactDetails.Add(contact);
            await _context.SaveChangesAsync();
            return Ok(await _context.ContactDetails.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<ContactDetails>> UpdateContact(ContactDetails request)
        {
            var contact = await _context.ContactDetails.FindAsync(request.Id);
            if (contact == null)
                return BadRequest("Contact not found");
            contact.Name = request.Name;
            contact.Address = request.Address;
            contact.Phone = request.Phone;
            contact.Comments = request.Comments;
            contact.LastDateContacted = request.LastDateContacted;
            contact.JobTitle = request.JobTitle;
            contact.Email = request.Email;
            contact.Company = request.Company;
            await _context.SaveChangesAsync();
            return Ok(await _context.ContactDetails.ToListAsync());
        }
    }
}
