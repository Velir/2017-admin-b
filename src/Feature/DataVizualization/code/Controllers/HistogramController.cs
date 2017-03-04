using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminB2017.Feature.DataVisualization.Controllers
{
    public class HistogramController : Controller
    {
        // GET: Histogram
        public ActionResult Index()
        {
          return View("~/Views/DataVisualization/Histogram.cshtml");
        }
    }
}