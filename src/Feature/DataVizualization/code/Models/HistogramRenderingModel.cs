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
    
    public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public TimePeriods TimePeriod { get; set; }

    public Uri DataUrl { get; set; }

    public bool ShowLabels { get; set; }

    public string DateColumnName { get; set; }

        public string MessageRequiredFieldMissing {  get { return "Your datasource is missing some required information.  You must supply a data link to a valid csv and the dat column name."; } }
  }

 
}