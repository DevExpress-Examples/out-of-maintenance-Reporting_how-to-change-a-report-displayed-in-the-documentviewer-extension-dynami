Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraReports.UI
Imports E5020.Reports
Imports E5020.Models

Namespace E5020.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Dim model As New ReportModel() With {.ReportName = "Categories"}
			Return View(model)
		End Function

		Public Function ReportCallbackPanelPartial(ByVal reportModel As ReportModel) As ActionResult
			Return PartialView("_ReportCallbackPanelPartial", reportModel)
		End Function

		Public Function DocumentViewerPartial(ByVal reportModel As ReportModel) As ActionResult
			Return PartialView("_DocumentViewerPartial", reportModel)
		End Function

		Public Function DocumentViewerExport(ByVal reportModel As ReportModel) As ActionResult
			Return DocumentViewerExtension.ExportTo(reportModel.CreateReport())
		End Function
	End Class
End Namespace