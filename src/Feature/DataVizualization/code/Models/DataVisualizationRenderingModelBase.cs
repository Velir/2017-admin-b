using System;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Diagnostics;
using Sitecore.XA.Foundation.Mvc.Models;

namespace AdminB2017.Feature.DataVisualization.Models
{
  public abstract class DataVisualizationRenderingModelBase : RenderingModelBase
  {
    private readonly string _id;
    public DataVisualizationRenderingModelBase()
    {
      _id = "a" + Guid.NewGuid().ToString("N"); //HTML Ids must begin with a letter
    }

    /// <summary>
    /// Used to identify DIV to D3.js
    /// </summary>
    public string Id { get { return _id; } }
 

    public HtmlString DataUrl { get; set; }

    public void SetDataUrl(LinkField linkField)
    {
      string theUrl;
      if (linkField.IsMediaLink)
      {
       theUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(linkField.TargetItem);
      }
      else
      {
        theUrl = linkField.Url;
      }

      if (!string.IsNullOrEmpty(theUrl))
      {
        DataUrl = new HtmlString(theUrl);
      }
    }
 
  }
}