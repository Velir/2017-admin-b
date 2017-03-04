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
  public class SunburstController : StandardController
  {
    private readonly ISunburstRepository _sunburstRepository;

    public SunburstController(ISunburstRepository sunburstRepository)
    {
      _sunburstRepository = sunburstRepository;
    }

    protected override object GetModel()
    {
      return _sunburstRepository.GetModel();
    }
  }
}