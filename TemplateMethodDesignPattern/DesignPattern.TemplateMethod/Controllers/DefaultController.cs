using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            netflixPlans.CreatePlan();
            //ViewBag.planType = netflixPlans.PlanType("Basic Plan");
            //ViewBag.countPerson = netflixPlans.CountPerson(1);
            //ViewBag.price=netflixPlans.Price(64.99);
            //ViewBag.resolution = netflixPlans.Resoltion("480px");
            //ViewBag.content = netflixPlans.Content("Film-Series");
            return View(netflixPlans);
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            netflixPlans.CreatePlan();
            //ViewBag.planType = netflixPlans.PlanType("Standart Plan");
            //ViewBag.countPerson = netflixPlans.CountPerson(2);
            //ViewBag.price=netflixPlans.Price(100);
            //ViewBag.resolution = netflixPlans.Resoltion("720px");
            //ViewBag.content = netflixPlans.Content("Film-Series-Animation");
            return View(netflixPlans);
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan ();
            netflixPlans.CreatePlan();
            //ViewBag.planType = netflixPlans.PlanType("Ultra Plan");
            //ViewBag.countPerson = netflixPlans.CountPerson(5);
            //ViewBag.price=netflixPlans.Price(150.99);
            //ViewBag.resolution = netflixPlans.Resoltion("1080px");
            //ViewBag.content = netflixPlans.Content("Film-Series-Animation - Documentary");
            return View(netflixPlans);
        }
    }
}
