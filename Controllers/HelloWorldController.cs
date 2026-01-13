using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        /*
        The ViewData dictionary is a dynamic object, which means any 
        type can be used. The ViewData object has no defined properties 
        until something is added. The MVC model binding system automatically 
        maps the named parameters name and numTimes from the query string to 
        parameters in the method. The complete HelloWorldController
        */
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}