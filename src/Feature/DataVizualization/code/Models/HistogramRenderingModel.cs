using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.Mvc.Models;

namespace AdminB2017.Feature.DataVisualization.Models
{
  public class HistogramRenderingModel : RenderingModelBase
  {
    DateTime FromDate { get { return  new DateTime(2016,2,1);} }

    DateTime ToDate { get { return new DateTime(2016,4,1);} }
  }
}