using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicketSupport.Models;


namespace TicketSupport.Controllers;

public class SupportController : Controller
{
    private readonly ILogger<SupportController> _logger;
    
    public SupportController(ILogger<SupportController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}