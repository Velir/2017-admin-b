# Data Visualization Package for Sitecore Experience Accelerator 

The Data Visualization Package (DatVizPak) for Sitecore Experience Accelerator (SXA) incorporates powerful data-driven visualizations into the standard SXA toolbox. SXA offers a wide range of components for content authors to speed up production of websites. DatVizPak extends the available components with powerful data visualizations that content editors can use to add a new dimension of content to their websites.

## Prerequisites

Before you can install DatVizPak, you need to install the following items:

* Sitecore 8.2 Update 2 (rev 161221) ([https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/82/Sitecore_Experience_Platform_82_Update2.aspx](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/82/Sitecore_Experience_Platform_82_Update2.aspx))
* Sitecore Powershell Extensions 4.3 ([https://marketplace.sitecore.net/Modules/S/Sitecore_PowerShell_console.aspx](https://marketplace.sitecore.net/Modules/S/Sitecore_PowerShell_console.aspx)) 
 * *N.B. Version 4.4 of Sitecore Powershell Extensions will cause errors.*
* Sitecore Experience Accelerator 1.2 ([https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/12/Sitecore_Experience_Accelerator_12_Initial_Release.aspx](https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/12/Sitecore_Experience_Accelerator_12_Initial_Release.aspx))

## Installation

1. Install Sitecore package: DatVizPak-1.0.0.0.zip.
2. Publish with subitems the following paths:
	1. /sitecore/layout/Renderings/Feature/Experience Accelerator/Data Visualizations
	2. /sitecore/system/Settings/Feature/Experience Accelerator/Data Visualizations
	3. /sitecore/templates/Branches/Feature/Experience Accelerator/Data Visualizations
	4. /sitecore/templates/Feature/Experience Accelerator/Data Visualizations

## Available Visualizations

DatVizPak comes with several data visualizations out of the box.

### Histogram

Histograms are graphical representations of the frequency of data events, usually over a range of time (read more at [Wikipedia](https://en.wikipedia.org/wiki/Histogram "Wikipedia")). 

### Scatter Plot 

Scatter plots are plots of data points on a Cartesian graph (read more at [Wikipedia](https://en.wikipedia.org/wiki/Scatter_plot "Wikipedia")).

### Sunburst

Sunbursts are a form of pie chart that use multilevel concentric circles to represent hierarchical data (read more at [Wikipedia](https://en.wikipedia.org/wiki/Pie_chart#Ring_chart_.2F_Sunburst_chart_.2F_Multilevel_pie_chart "Wikipedia")). The sunburst visualization provided in DatVizPak are interactive, allowing for zooming in and out to examine data more closely. 

## Inserting Data Visualizations

DatVizPak updates the SXA toolbox with all of the new visualizations:

![Toolbox](https://i.imgur.com/NPBr2CV.png)

After inserting a data visualization component, component properties will pop up. Configure the properties for the data visualization and click "OK". 

*N.B. In Experience Editor, the data visualization component will show only a static image representing the type of data visualization. View the page in Preview Mode to see the actual visualization.*

## Warning About External Data Sources

DatVizPak allows for content editors to configure visualizations to pull from data sources hosted on an external site. However, the external site must have [CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing "CORS") enabled or DatVizPak will not be able to load the data. To visualize data from external sites without CORS enabled, download the data from the external site and upload the data to Sitecore. 

## Customizing DatVizPak

You can customize DatVizPak in several different ways.

### [Add customizations here]

## Developer Bootstrap

Want to develop for DatVizPak? Great! To get started developing for DatVizPak, you must first do some things:

* Add SXA assemblies to the /lib folder.
 * Because SXA DLLs are not available yet on Sitecore's NuGet feed, you must manually add them here.
 * See [here](/lib#sxa-dependencies "/lib/readme.md") for details.
* 

## About the Authors

DatVizPak was created by the [Velir](https://www.velir.com "Velir") team admin/b (Dan Solovay, Nicole Durand, Ed Schwehm) as part of [2017 Sitecore Hackathon](http://www.sitecorehackathon.org/sitecore-hackathon-2017/ "Sitecore Hackathon 2017").