﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminB2017.Feature.DataVisualization.Repositories;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace AdminB2017.Feature.DataVisualization.Controllers
{
    public class HistogramController : StandardController
    {
      private readonly IHistogramRepository _histogramRepository;

      public HistogramController(IHistogramRepository histogramRepository)
      {
        _histogramRepository = histogramRepository;
      }

      protected override object GetModel()
      {
        return _histogramRepository.GetModel();
      }
    }
}