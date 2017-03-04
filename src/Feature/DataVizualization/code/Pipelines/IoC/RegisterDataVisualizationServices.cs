using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminB2017.Feature.DataVisualization.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.XA.Foundation.IOC.Pipelines.IOC;

namespace AdminB2017.Feature.DataVisualization.Pipelines.IoC
{
  public class RegisterDataVisualizationServices:IocProcessor
  {
    public override void Process(IocArgs args)
    {
      ServiceCollectionServiceExtensions.AddTransient<IHistogramRepository, HistogramRepository>(args.ServiceCollection);
    }
  }
}