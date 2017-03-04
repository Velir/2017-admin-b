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
  public class SunburstRepository : ModelRepository, ISunburstRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
  {
    public override IRenderingModelBase GetModel()
    {
      var model = new SunburstRenderingModel();
      this.FillBaseProperties(model);
      //TODO Handle null datasource.
      model.SetDataUrl(model.DataSourceItem.Fields[Templates.DataVisualization.Fields.Data]);

      
      model.ValueFieldName = model.DataSourceItem.Fields[Templates.Sunburst.Fields.ValueFieldName].Value;

      return model;
    }
  }
}