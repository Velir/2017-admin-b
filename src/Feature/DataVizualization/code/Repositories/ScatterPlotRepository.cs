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
      //TODO Handle null datasource.
      LookupField timePeriod = model.DataSourceItem.Fields[Templates.Histogram.Fields.TimePeriod];
      model.TimePeriod = (TimePeriods)Enum.Parse(typeof(TimePeriods), timePeriod.TargetItem.Fields["Value"].Value); //TODO Pull from Foundation.  And put this in a method.
      LinkField field = model.DataSourceItem.Fields[Templates.Histogram.Fields.Data];
      model.DataUrl = new Uri(field.Url);
      model.ShowLabels = !(string.IsNullOrWhiteSpace(this.Rendering.Parameters[Constants.ShowLabels]) ||
      this.Rendering.Parameters[Constants.ShowLabels] == "0"); //TODO Clean up

      model.DateColumnName = model.DataSourceItem.Fields[Templates.Histogram.Fields.DataColumnName].Value;
      return model;
    }
  }
}