using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using AdminB2017.Feature.DataVisualization.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace AdminB2017.Feature.DataVisualization.Repositories
{
  public class HistogramRepository : ModelRepository, IHistogramRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
  {
    public override IRenderingModelBase GetModel()
    {
      HistogramRenderingModel model = new HistogramRenderingModel();
      model.TimePeriod = TimePeriods.Month;
      model.DataUrl =new Uri("https://data.cityofnewyork.us/api/views/3q43-55fe/rows.csv");
      model.ShowLabels = true;
      model.DateColumnName = "Created Date";
      return model;
    }
  }
}