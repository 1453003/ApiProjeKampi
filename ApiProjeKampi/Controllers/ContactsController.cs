using ApiProjeKampi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;
        public ContactsController(ApiContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult ContacatList()
        {
            var value = _context.Contacts.ToList();
            return Ok("kategoriler listelendi");
        }
    }
}
