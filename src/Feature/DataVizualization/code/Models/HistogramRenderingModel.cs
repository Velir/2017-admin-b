using System;
using Sitecore.XA.Foundation.Mvc.Models;

namespace AdminB2017.Feature.DataVisualization.Models
{
  public class HistogramRenderingModel : DataVisualizationRenderingModelBase
  {
     
    public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public TimePeriods TimePeriod { get; set; }

    public bool ShowLabels { get; set; }

    public string DateColumnName { get; set; }

        public string MessageRequiredFieldMissing {  get { return "Your datasource is missing some required information.  You must supply a data link to a valid csv and the dat column name."; } }
  }

 
}