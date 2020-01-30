using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC1.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string name = "<form method ='post' action = '/Hello/Display' >" + "<input type='text' name= 'name'/>";
            string language = "<select name = 'language'>" + "<option value = 'english'> English </option>" +
                "<option value = 'french'> French </option>" + "<option value = 'spanish'> Spanish </option>" + "<option value = 'italian'> Italian </option>" +
                "<option value = 'alb'> Albanian </option>" + "</select>" + "<input type='submit' value='Greet me!'/>" 
                + "</form>";
            string both = name + language;
            return Content(both, "text/html");
        }
        public static string CreateMessage(string name, string language)
        {
            string greeting = "";
            if (language == "english")
            {
                greeting = "Hello";
            }
            else if(language == "french")
            {
                greeting = "Bonjour";
            }
            else if(language == "spanish")
            {
                greeting = "Hola";
            }
            else if(language == "italian")
            {
                greeting = "Ciao";
            }
            else if(language == "alb")
            {
                greeting = "Pershendetje";
            }
            
             return String.Format("<h1> {0} {1} </h1>", greeting, name);
        }
        public IActionResult Display(string name, string language)
        {
            return Content(CreateMessage(name, language), "text/html");
        }
    }
}
