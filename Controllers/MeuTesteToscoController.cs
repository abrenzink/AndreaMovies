using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

//ATENÇÂO: o nome que você define aqui é a rota que ficará acessível
public class MeuTesteToscoController : Controller
{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is MEU TESTE TOSCO default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome TOSCO action method...";
    }
}

/*
    The default URL routing logic used by MVC, uses a format like this to determine what code to invoke:

    /[Controller]/[ActionName]/[Parameters]

    The routing format is set in the Program.cs file.

    C#
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
*/