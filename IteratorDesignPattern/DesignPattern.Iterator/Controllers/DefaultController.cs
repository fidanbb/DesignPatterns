using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> values= new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "German", CityName = "Berlin", VisitPlaceName = "Berlin Gate" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "France", CityName = "Paris", VisitPlaceName = "Eiffel" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Italy", CityName = "Venice", VisitPlaceName = "Gondola Ride" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Italy", CityName = "Rome", VisitPlaceName = "Colosseum" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Czechia", CityName = "Prague", VisitPlaceName = "Prague Square" });
           
            var iterator=visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                values.Add(iterator.CurrentItem.CountryName + " "
                    + iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);
            }

            ViewBag.values = values;
            
            return View();
        }
    }
}
