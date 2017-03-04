using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminB2017.Feature.DataVisualization.Repositories;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace AdminB2017.Feature.DataVisualization.Controllers
{
  public class ScatterPlotController : StandardController
  { 
    private readonly IScatterPlotRepository _scatterPlotRepository;

    public ScatterPlotController(IScatterPlotRepository scatterPlotRepository)
    {
      _scatterPlotRepository = scatterPlotRepository;
    }

    protected override object GetModel()
    {
      return _scatterPlotRepository.GetModel();
    }
  }
}