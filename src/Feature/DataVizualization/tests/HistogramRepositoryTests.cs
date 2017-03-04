using System;
using AdminB2017.Feature.DataVisualization.Repositories;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Sitecore.Configuration;
using Sitecore.Pipelines.HttpRequest;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.IoC.Locator;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;
using Xunit;

namespace Admin2017.Feature.DataVisualization.UnitTests
{
  /// <summary>
  /// Exploration of SXA testability. Still in progress.
  /// </summary>
  public class HistogramRepositoryTests
  {
    private HistogramRepository _sut = new TestableHistogramRepository();
    

    [Fact(Skip="Have not yet isolated depenedencies from ModelRepository base class.")]
    public void GetModel_WhenCalled_DoesntThorw()
    {
       
      var model = _sut.GetModel();



    }
  }

  internal class TestableHistogramRepository : HistogramRepository
  {
    protected override IRendering Rendering {
      get { return Substitute.For<IRendering>(); }
    }

    protected override IPageContext PageContext { get { return Substitute.For<IPageContext>(); } }

     
  }
}
