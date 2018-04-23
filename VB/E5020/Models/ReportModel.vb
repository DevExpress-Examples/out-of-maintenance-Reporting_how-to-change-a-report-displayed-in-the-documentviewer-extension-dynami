Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI
Imports E5020.Reports

Namespace E5020.Models
	Public Class ReportModel
		Private privateReportName As String
		Public Property ReportName() As String
			Get
				Return privateReportName
			End Get
			Set(ByVal value As String)
				privateReportName = value
			End Set
		End Property

		Public Function CreateReport() As XtraReport
			Select Case ReportName
				Case "Categories"
					Return New CategoriesReport()
				Case "Products"
					Return New ProductsReport()
				Case "Orders"
					Return New OrdersReport()
			End Select
			Return Nothing
		End Function
	End Class
End Namespace