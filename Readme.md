<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596350/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5020)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E5020/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5020/Controllers/HomeController.vb))
* [ReportModel.cs](./CS/E5020/Models/ReportModel.cs) (VB: [ReportModel.vb](./VB/E5020/Models/ReportModel.vb))
* [_DocumentViewerPartial.cshtml](./CS/E5020/Views/Home/_DocumentViewerPartial.cshtml)
* [_ReportCallbackPanelPartial.cshtml](./CS/E5020/Views/Home/_ReportCallbackPanelPartial.cshtml)
* **[Index.cshtml](./CS/E5020/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to change a report displayed in the DocumentViewer extension dynamically
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5020/)**
<!-- run online end -->


<p>This example demonstrates how you can dynamically change a report displayed by the DocumentViewer extension.<br />
</p><p>A callback is used to switch reports. So, the DocumentViewer extension is placed into the CallbackPanel extension. After the ComboBox selection is changed, a callback is sent to the CallbackPanel extension to update the DocumentViewer.</p>

<br/>


