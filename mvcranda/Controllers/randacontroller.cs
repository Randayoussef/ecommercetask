using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Mvcranda.controllers
{
    public class randaController : Controller
    {
        
        

        public string Index()
        {
            return "hello my name is randa ";
        }

        
        

        public string Welcome()
        {
            return "this is my welcome page ";
        }
    }
}