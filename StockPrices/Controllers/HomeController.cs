using StockPrices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockPrices.Controllers
{
    public class HomeController : Controller
    {
        private List<Stock> objGameList;
        public HomeController()
        {
            objGameList = new List<Stock>() {
                new Stock { Value="AYI"},
                new Stock { Value="A2B"},
                new Stock { Value="ABP"},
                new Stock { Value="ABL"},
                new Stock { Value="REG"},
                new Stock { Value="ABT"},
                new Stock { Value="AJC"},
                new Stock { Value="AKG"},
                new Stock { Value="NX8"},
                new Stock { Value="AX1"},
                new Stock { Value="XYZCS"},
                new Stock { Value="OCQ"},
                new Stock { Value="ACF"},
                new Stock { Value="BCR"},
                new Stock { Value="ACW"},
                new Stock { Value="AIV"},
                new Stock { Value="CDA"},
                new Stock { Value="XYZDH"},
                new Stock { Value="1AD"},
                new Stock { Value="ADD"},
                new Stock { Value="AAU"},
                new Stock { Value="ABC"},
                new Stock { Value="XYZ"},
                new Stock { Value="EHZ"},
                new Stock { Value="ADY"},
                new Stock { Value="ADT"},
                new Stock { Value="ZDJ"},
        };
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Prefix)
        {

            List<Stock> result;
            if(Prefix != null)
            {
                result = (from stock in objGameList
                          where stock.Value.StartsWith(Prefix)
                          select stock).ToList<Stock>();
            }
            else
            {
                result = objGameList.ToList<Stock>();
            }

            return PartialView("Stock", result);
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}