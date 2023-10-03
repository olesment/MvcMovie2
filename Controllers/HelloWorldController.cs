using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // PART 333333333
    //eplace the Index method with the following code:
    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}
    public IActionResult Index()
    {
        return View();
    }
    // 333333
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    // ADD A CONTROLLER 222222222222222222222222222222222222222222
    // GET: /HelloWorld/Welcome/ 
    //Change the Welcome method to include two parameters as shown in the following code
    //public string Welcome()
    //{
    //    return "This is the Welcome action method...";
    //}

    //public string Welcome(string name, int numTimes = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}
    //success

    //Replace the Welcome method with the following code:

    //    public string Welcome(string name, int ID = 1) // v2lja kommenteeritud sest: tut 3:  The complete HelloWorldController:
    //    {
    //        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //    }
}