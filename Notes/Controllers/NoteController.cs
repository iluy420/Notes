using Microsoft.AspNetCore.Mvc;

namespace Notes.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
