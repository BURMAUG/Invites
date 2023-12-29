using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public ViewResult RsvpForm()
    {
        return View("RsvpForm");
    }
    public ViewResult AttendeeList()
    {
        return View();
    }
}
