using Microsoft.AspNet.Identity;
using Resturant.Models;
using Resturant.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resturant.Controllers.Resturant
{
    public class ResturantController : Controller
    {
        Context context = new Context();
        // GET: Resturant
        public ActionResult Index(string Place)
        {

            var resturants = context.Resturants.Where(res=>res.Place==Place).ToList() ;
            if (resturants != null)
            {
                foreach (var item in resturants)
                {
                    var Res = context.ResturantRates.Where(re => re.RestID == item.ID);
                    var ResList = Res.ToList();
                    if (ResList.Count != 0)
                    {
                        double rates = Res.Select(ra => ra.Rate).Average();
                        // var selectedRest = context.Resturants.Where(s => s.ID == item.ID);
                        item.Rate = Convert.ToInt32(rates);
                    }

                }

                context.SaveChanges();
            }
            return View(resturants);
        }
        [HttpGet]
        public ActionResult AddResturant()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddResturant(Models.DB.Resturant resturant)
        {
            context.Resturants.Add(resturant);
            context.SaveChanges();
            return RedirectToAction("Index","Home");

        }
        [HttpGet]
        [Authorize]
        public ActionResult ShowDetails(int ID)
        {
            var res= context.Resturants.Where(re => re.ID == ID).First();
            var resFeedback = context.ResturantRates.Where(ress => ress.RestID == ID).ToList();
            res.ResturantRates = resFeedback;
            return View(res);
        }
        
        public ActionResult ShowDetailss(ResturantRate resRate)
        {
            var CurrUser = User.Identity.GetUserName();
            resRate.UserId = CurrUser;
            resRate.FeedbackRate = DateTime.Now;
            context.ResturantRates.Add(resRate);
            context.SaveChanges();
            var resFeedback = context.ResturantRates.Where(ress => ress.RestID == resRate.RestID).ToList();
            
            return PartialView("ShowDetailssss",resFeedback );
        }
    }
}