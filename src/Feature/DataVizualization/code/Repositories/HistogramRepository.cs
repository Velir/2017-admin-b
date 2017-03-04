using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminB2017.Feature.DataVisualization.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace AdminB2017.Feature.DataVisualization.Repositories
{
  public class HistogramRepository : ModelRepository, IHistogramRepository, IModelRepository, IAbstractRepository<IRenderingModelBase>
  {
    public override IRenderingModelBase GetModel()
    {
      return new HistogramRenderingModel();
    }
  }
}