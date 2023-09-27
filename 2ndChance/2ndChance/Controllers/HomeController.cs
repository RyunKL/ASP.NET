using _2ndChance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _2ndChance.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext _contactContext { get; set; }
        public HomeController(ContactContext ctx)
        {
            _contactContext = ctx;
        }
        public IActionResult Index()
        {
            var contacts = _contactContext.Contacts.Include(c => c.Category).OrderBy(c => c.FirstName).ToList();

            return View(contacts);
        }
    }
}