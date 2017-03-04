using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using AdminB2017.Feature.DataVisualization.Models;
using Sitecore;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace AdminB2017.Feature.DataVisualization.Repositories
{
  public class HistogramRepository : ModelRepository, IHistogramRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
  {
    public override IRenderingModelBase GetModel()
    {
      HistogramRenderingModel model = new HistogramRenderingModel();
      this.FillBaseProperties(model);
      if (model.DataSourceItem != null)
      {
        LookupField timePeriod = model.DataSourceItem.Fields[Templates.Histogram.Fields.TimePeriod];
        if (timePeriod.TargetItem != null)
          model.TimePeriod = (TimePeriods)Enum.Parse(typeof(TimePeriods), timePeriod.TargetItem.Fields["Value"].Value); //TODO Pull from Foundation.  And put this in a method.
        model.SetDataUrl(model.DataSourceItem.Fields[Templates.DataVisualization.Fields.Data]);
        model.ShowLabels = !(string.IsNullOrWhiteSpace(this.Rendering.Parameters[Constants.ShowLabels]) ||
                this.Rendering.Parameters[Constants.ShowLabels] == "0"); //TODO Clean up
        DateField fromDate = model.DataSourceItem.Fields[Templates.Histogram.Fields.FromDate];
        if (fromDate.DateTime != DateTime.MinValue)
          model.FromDate = fromDate.DateTime;
        DateField toDate = model.DataSourceItem.Fields[Templates.Histogram.Fields.ToDate];
        if (toDate.DateTime != DateTime.MinValue)
          model.ToDate = toDate.DateTime;
        TextField dataColumnName = model.DataSourceItem.Fields[Templates.Histogram.Fields.DataColumnName];
        if (!string.IsNullOrWhiteSpace(dataColumnName.Value))
          model.DateColumnName = dataColumnName.Value;
      }
      return model;
    }
  }
}