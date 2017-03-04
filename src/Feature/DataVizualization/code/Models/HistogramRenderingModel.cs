using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using Sitecore.ApplicationCenter.Applications;
using Sitecore.XA.Foundation.Mvc.Models;

namespace AdminB2017.Feature.DataVisualization.Models
{
  public class HistogramRenderingModel : RenderingModelBase
  {
    private readonly string _id;
    public HistogramRenderingModel()
    {
      _id = "a" + Guid.NewGuid().ToString("N");
    }

    /// <summary>
    /// Used to identify DIV to D3.js
    /// </summary>
    public string Id { get { return _id; } }
    
    public DateTime FromDate { get { return  new DateTime(2016,2,1);} }

    public DateTime ToDate { get { return new DateTime(2016,4,1);} }

    public TimePeriods TimePeriod { get; set; }

    public Uri DataUrl { get; set; }

    public bool ShowLabels { get; set; }

    public string DateColumnName { get; set; }
  }

 
}