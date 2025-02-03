using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly OnlineUsersService _onlineUsersService;

    public HomeController(OnlineUsersService onlineUsersService)
    {
        _onlineUsersService = onlineUsersService;
    }

    public IActionResult Index()
    {
        ViewBag.OnlineUsersCount = _onlineUsersService.GetOnlineUsersCount();
        return View();
    }

    [HttpPost]
    public IActionResult RemoveUser()
    {
        var cookieValue = Request.Cookies["UserOnlineCookie"];
        if (cookieValue != null)
        {
            _onlineUsersService.RemoveUser(cookieValue);
        }
        return Ok();
    }
}
