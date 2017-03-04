using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace AdminB2017.Feature.DataVisualization
{
  public class Templates
  {

    public struct DataVisualization
    {
      public static readonly ID ID  = new ID("{4FAB734C-3BAB-455A-9E3D-4FC82C52F13C}");

      public struct Fields
      {
        public static readonly ID Data = new ID("{ECD7765B-8B05-4404-AB91-238E69446C2E}");
      }
    }

    public struct Histogram
    {
      public static readonly ID ID = new ID("{96468976-43DC-4594-83DD-4AA7CF7020C2}");

      public struct Fields
      {
        public static readonly ID FromDate = new ID("{F34BE7C0-C003-4D3A-A79C-2E62AB77FCF4}");
        public static readonly ID ToDate = new ID("{8628C4F2-9684-44C1-92FE-7EAB7E0825E6}");
        public static readonly ID TimePeriod = new ID("{77C78985-50DA-41E0-AD90-9F02D4C8EB63}");
        public static readonly ID DataColumnName = new ID("{6A2E628C-4B5D-427C-9CB7-08A0BDF3DBF0}");
      }
    }
  }
}