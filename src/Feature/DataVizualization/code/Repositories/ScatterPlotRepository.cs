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
  public class ScatterPlotRepository:ModelRepository, IScatterPlotRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
  {
    public override IRenderingModelBase GetModel()
    {
      ScatterPlotRenderingModel model = new ScatterPlotRenderingModel();
      this.FillBaseProperties(model);
      //TODO Handle null datasource.
      model.SetDataUrl(model.DataSourceItem.Fields[Templates.DataVisualization.Fields.Data]);

      return model;
    }
  }
}