# Data Visualization Package for Sitecore Experience Accelerator 

![Data Visualation Package (DatVizPack)](https://i.imgur.com/XdEer90.png)

The Data Visualization Package (DataVizPak) for Sitecore Experience Accelerator (SXA) incorporates powerful data-driven visualizations into the standard SXA toolbox. SXA offers a wide range of components for content authors to speed up production of websites. DataVizPak extends the available components with powerful data visualizations that content editors can use to add a new dimension of content to their websites.

## Prerequisites

Before you can install DataVizPak, you need to install the following items:

* Sitecore 8.2 Update 2 (rev 161221) ([https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/82/Sitecore_Experience_Platform_82_Update2.aspx](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/82/Sitecore_Experience_Platform_82_Update2.aspx))
* Sitecore Powershell Extensions 4.3 ([https://marketplace.sitecore.net/Modules/S/Sitecore_PowerShell_console.aspx](https://marketplace.sitecore.net/Modules/S/Sitecore_PowerShell_console.aspx)) 
 * *N.B. Version 4.4 of Sitecore Powershell Extensions will cause errors.*
* Sitecore Experience Accelerator 1.2 ([https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/12/Sitecore_Experience_Accelerator_12_Initial_Release.aspx](https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/12/Sitecore_Experience_Accelerator_12_Initial_Release.aspx))

## Installation

1. Install Sitecore package: DataVizPak-1.0.0.0.zip.
2. Publish with subitems the following paths:
	1. /sitecore/layout/Renderings/Feature/Experience Accelerator/Data Visualizations
	2. /sitecore/system/Settings/Feature/Experience Accelerator/Data Visualizations
	3. /sitecore/templates/Branches/Feature/Experience Accelerator/Data Visualizations
	4. /sitecore/templates/Feature/Experience Accelerator/Data Visualizations

## Available Visualizations

DataVizPak comes with several data visualizations out of the box.

### Histogram

Histograms are graphical representations of the frequency of data events, usually over a range of time (read more at [Wikipedia](https://en.wikipedia.org/wiki/Histogram "Wikipedia")). 

#### Histogram Parameters

Histogram visualizations in DataVizPak have several fields required for configuration. These fields are available on the datasource item. 

* **Data**: A link to the actual source of data. The data must be in a comma-separated list (CSV). 
* **From Date**: The date the histogram will start. The default value is one month before the current day
* **To Date**: The date the histogram will end.
 * _N.B. If you select a from date earlier than the start of data or a to date later than the end of data, the histogram will still extend to the dates configured with zero-columns._
* **Time Period**: The length of time that each histogram column will represent. Options are day, week, and month.
* **Date Column Name**: The name of the column in the data that represents the date to be used for the x-axis. 
 * _N.B. This field is case-sensitive._

Additionally, the "Show Labels" check box is available on the component properties. If checked, the histogram will include labels of the data value on each column. 

#### Scatter Plot Parameters

Scatter Plot visualizations in DataVizPak have several fields required for configuration. These fields are available on the datasource item. 

* **Data**: A link to the actual source of data. The data must be in a comma-separated list (CSV). 
* **DateColumnName**: The name of the column in the data that represents the date to be used for the x-axis. 
* **Date Column Name**: The name of the column in the data that represents the value to be displayed the the y-axis.
 * _N.B. This field is case-sensitive._

### Scatter Plot 

Scatter plots are plots of data points on a Cartesian graph (read more at [Wikipedia](https://en.wikipedia.org/wiki/Scatter_plot "Wikipedia")).

### Sunburst

Sunbursts are a form of pie chart that use multilevel concentric circles to represent hierarchical data (read more at [Wikipedia](https://en.wikipedia.org/wiki/Pie_chart#Ring_chart_.2F_Sunburst_chart_.2F_Multilevel_pie_chart "Wikipedia")). The sunburst visualization provided in DataVizPak is interactive, allowing for zooming in and out to examine data more closely. 

## Using DataVizPak

When creating a new site, make sure the "Data Visualizations" feature is enabled:
![New SXA Site - Features](https://i.imgur.com/22YtGiz.png)

_N.B. If you would like to add data visualizations from DatVizPack to an existing SXA site, you need to manually update the site items in Sitecore to add the features._

DataVizPak updates the SXA toolbox with all of the new visualizations:

![Toolbox](https://i.imgur.com/NPBr2CV.png)

Select the datasource (or create a new one) and click "OK".

![Datasource](https://i.imgur.com/uOiDySP.png)

**_KNOWN ISSUE ALERT_**: The first visualization added to any page will not show up in experience editor, and the save button will not be enabled. To save the component, make an edit to some other part of the page and save the page. The visualization will properly appear after saving. This issue is documents as [#30](https://github.com/Velir/admin-b//issues/30 "#30"). This will be fixed in DataVizPak Mark II.

After inserting a data visualization component, component properties will pop up. Configure the properties for the data visualization and click "OK". 

The visualization component will be present on the page. If you created a new datasource,  the visualization will be blank.

![New Blank Histogram](https://i.imgur.com/gi2HiZj.png)

You'll need to update the datasource fields with the data and parameters you want.

![Datasource Parameters](https://i.imgur.com/VIRKPxP.png)

Save and close the datasource, and voilà, you have a visualization!

![Histogram](https://i.imgur.com/M3E3hNZ.png)

## Warning About External Data Sources

DataVizPak allows for content editors to configure visualizations to pull from data sources hosted on an external site. However, the external site must have [CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing "CORS") enabled or DataVizPak will not be able to load the data. To visualize data from external sites without CORS enabled, download the data from the external site and upload the data to Sitecore. 

## Known Issues

DataVizPak Mark I has several known issues. The notable issues are listed below; you can find the full list at [/issues](https://github.com/Velir/admin-b/issues "issues"): 

* First visualization added to a page does not show at first or set page as "dirty": [#30](https://github.com/Velir/admin-b/issues/30 "#30") and [#28](https://github.com/Velir/admin-b/issues/28 "#28")
* Only one instance of each type of visualization can be added to a page: [#29](https://github.com/Velir/admin-b/issues/29 "#29")

These notable issues will be resolved in DataVizPak Mark II.

## Roadmap

1. DataVizPak Mark II:
 1. Resolve issues [#28](https://github.com/Velir/admin-b/issues/28 "#28"), [#29](https://github.com/Velir/admin-b/issues/29 "#29"), and [#30](https://github.com/Velir/admin-b/issues/30 "#30").  
 2. Update visualizations to act more in line with "Wireframe" theme ([#24](https://github.com/Velir/admin-b/issues/24 "#24")).
3. DataVizPak Mark III:
	1. Add additional style color options ([#21](https://github.com/Velir/admin-b/issues/21 "#21")).
	1. Add the ability to select rolling time frames for histograms and scatter plots ([#27](https://github.com/Velir/admin-b/issues/27 "#27")).
2. DataVizPak Mark IV:
	1. Add new visualization types: line chart ([#31](https://github.com/Velir/admin-b/issues/31 "#31")) and pie chart ([#32](https://github.com/Velir/admin-b/issues/32 "#32"))

## Developer Bootstrap

Want to develop for DataVizPak? Great! To get started developing for DataVizPak, you must first do some things:

* Add SXA assemblies to the /lib folder.
 * Because SXA DLLs are not available yet on Sitecore's NuGet feed, you must manually add them here.
 * See [here](/lib#sxa-dependencies "/lib/readme.md") for details.
* It's probably a good idea to either publish the entire site or publish all non-content items, just to be sure. 

## About the Authors

DataVizPak was created by the [Velir](https://www.velir.com "Velir") [team admin/b](https://github.com/Velir/admin-b/wiki/Team-admin-b "admin/b") (Dan Solovay, Nicole Durand, Ed Schwehm) as part of [2017 Sitecore Hackathon](http://www.sitecorehackathon.org/sitecore-hackathon-2017/ "Sitecore Hackathon 2017").