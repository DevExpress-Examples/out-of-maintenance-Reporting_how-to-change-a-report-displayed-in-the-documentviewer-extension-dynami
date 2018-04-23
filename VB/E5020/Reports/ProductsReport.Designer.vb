Imports Microsoft.VisualBasic
Imports System
Namespace E5020.Reports
	Partial Public Class ProductsReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.tbProductData = New DevExpress.XtraReports.UI.XRTable()
			Me.trProductData = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcProductName = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsInStock = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsOnOrder = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcDiscont = New DevExpress.XtraReports.UI.XRTableCell()
			Me.cbDiscont = New DevExpress.XtraReports.UI.XRCheckBox()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nWindDataSet1 = New NWindDataSet()
            Me.productsTableAdapter = New NWindDataSetTableAdapters.ProductsTableAdapter()
			Me.GroupHeaderCategory = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.tbCategory = New DevExpress.XtraReports.UI.XRTable()
			Me.trCategory = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcCategory = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupHeaderTitle = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.tbProductHeader = New DevExpress.XtraReports.UI.XRTable()
			Me.trProductHeader = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tcProductNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitPriceHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsInStockHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcUnitsOnOrderHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tcDiscontHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.tbProductData, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductData})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseBorders = False
			Me.Detail.StylePriority.UseTextAlignment = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' tbProductData
			' 
			Me.tbProductData.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.tbProductData.Name = "tbProductData"
			Me.tbProductData.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trProductData})
			Me.tbProductData.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
			' 
			' trProductData
			' 
			Me.trProductData.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductName, Me.tcUnitPrice, Me.tcUnitsInStock, Me.tcUnitsOnOrder, Me.tcDiscont})
			Me.trProductData.Name = "trProductData"
			Me.trProductData.Weight = 1R
			' 
			' tcProductName
			' 
			Me.tcProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.tcProductName.Name = "tcProductName"
			Me.tcProductName.StylePriority.UseTextAlignment = False
			Me.tcProductName.Text = "tcProductName"
			Me.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.tcProductName.Weight = 1.3798077514467915R
			' 
			' tcUnitPrice
			' 
			Me.tcUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
			Me.tcUnitPrice.Name = "tcUnitPrice"
			Me.tcUnitPrice.StylePriority.UseTextAlignment = False
			Me.tcUnitPrice.Text = "tcUnitPrice"
			Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitPrice.Weight = 0.4663461624235804R
			' 
			' tcUnitsInStock
			' 
			Me.tcUnitsInStock.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.tcUnitsInStock.Name = "tcUnitsInStock"
			Me.tcUnitsInStock.StylePriority.UseTextAlignment = False
			Me.tcUnitsInStock.Text = "tcUnitsInStock"
			Me.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitsInStock.Weight = 0.46634616242358046R
			' 
			' tcUnitsOnOrder
			' 
			Me.tcUnitsOnOrder.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.tcUnitsOnOrder.Name = "tcUnitsOnOrder"
			Me.tcUnitsOnOrder.StylePriority.UseTextAlignment = False
			Me.tcUnitsOnOrder.Text = "tcUnitsOnOrder"
			Me.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tcUnitsOnOrder.Weight = 0.44903843327809811R
			' 
			' tcDiscont
			' 
			Me.tcDiscont.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.cbDiscont})
			Me.tcDiscont.Name = "tcDiscont"
			Me.tcDiscont.Text = "tcDiscont"
			Me.tcDiscont.Weight = 0.2384614904279494R
			' 
			' cbDiscont
			' 
			Me.cbDiscont.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.cbDiscont.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.cbDiscont.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.cbDiscont.Name = "cbDiscont"
			Me.cbDiscont.SizeF = New System.Drawing.SizeF(51.66656F, 25F)
			Me.cbDiscont.StylePriority.UseBorders = False
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nWindDataSet1
			' 
			Me.nWindDataSet1.DataSetName = "NWindDataSet"
			Me.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeaderCategory
			' 
			Me.GroupHeaderCategory.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.GroupHeaderCategory.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbCategory})
			Me.GroupHeaderCategory.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeaderCategory.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeaderCategory.HeightF = 25F
			Me.GroupHeaderCategory.Name = "GroupHeaderCategory"
			Me.GroupHeaderCategory.RepeatEveryPage = True
			Me.GroupHeaderCategory.StylePriority.UseBorders = False
			Me.GroupHeaderCategory.StylePriority.UseTextAlignment = False
			Me.GroupHeaderCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' tbCategory
			' 
			Me.tbCategory.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.tbCategory.Name = "tbCategory"
			Me.tbCategory.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trCategory})
			Me.tbCategory.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
			' 
			' trCategory
			' 
			Me.trCategory.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcCategory})
			Me.trCategory.Name = "trCategory"
			Me.trCategory.Weight = 1R
			' 
			' tcCategory
			' 
			Me.tcCategory.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.tcCategory.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.CategoryName")})
			Me.tcCategory.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.tcCategory.Name = "tcCategory"
			Me.tcCategory.StylePriority.UseBorders = False
			Me.tcCategory.StylePriority.UseFont = False
			Me.tcCategory.StylePriority.UseTextAlignment = False
			Me.tcCategory.Text = "xrTableCell2"
			Me.tcCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.tcCategory.Weight = 3R
			' 
			' GroupHeaderTitle
			' 
			Me.GroupHeaderTitle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.GroupHeaderTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductHeader})
			Me.GroupHeaderTitle.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeaderTitle.HeightF = 25F
			Me.GroupHeaderTitle.Level = 1
			Me.GroupHeaderTitle.Name = "GroupHeaderTitle"
			Me.GroupHeaderTitle.RepeatEveryPage = True
			Me.GroupHeaderTitle.StylePriority.UseBorders = False
			Me.GroupHeaderTitle.StylePriority.UseFont = False
			Me.GroupHeaderTitle.StylePriority.UseTextAlignment = False
			Me.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' tbProductHeader
			' 
			Me.tbProductHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.tbProductHeader.Name = "tbProductHeader"
			Me.tbProductHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trProductHeader})
			Me.tbProductHeader.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
			' 
			' trProductHeader
			' 
			Me.trProductHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontHeader})
			Me.trProductHeader.Name = "trProductHeader"
			Me.trProductHeader.Weight = 1R
			' 
			' tcProductNameHeader
			' 
			Me.tcProductNameHeader.Name = "tcProductNameHeader"
			Me.tcProductNameHeader.Text = "Product Name"
			Me.tcProductNameHeader.Weight = 1.379807857084572R
			' 
			' tcUnitPriceHeader
			' 
			Me.tcUnitPriceHeader.Name = "tcUnitPriceHeader"
			Me.tcUnitPriceHeader.Text = "Unit Price"
			Me.tcUnitPriceHeader.Weight = 0.4663460215732067R
			' 
			' tcUnitsInStockHeader
			' 
			Me.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader"
			Me.tcUnitsInStockHeader.Text = "Units In Stock"
			Me.tcUnitsInStockHeader.Weight = 0.46634598636061309R
			' 
			' tcUnitsOnOrderHeader
			' 
			Me.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader"
			Me.tcUnitsOnOrderHeader.Text = "Units On Order"
			Me.tcUnitsOnOrderHeader.Weight = 0.44903843327809806R
			' 
			' tcDiscontHeader
			' 
			Me.tcDiscontHeader.Name = "tcDiscontHeader"
			Me.tcDiscontHeader.Text = "Discont."
			Me.tcDiscontHeader.Weight = 0.23846170170351017R
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Products Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ProductsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderCategory, Me.GroupHeaderTitle, Me.ReportHeader})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nWindDataSet1
			Me.Version = "13.2"
			CType(Me.tbProductData, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private tbProductData As DevExpress.XtraReports.UI.XRTable
		Private trProductData As DevExpress.XtraReports.UI.XRTableRow
		Private tcProductName As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitPrice As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsInStock As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsOnOrder As DevExpress.XtraReports.UI.XRTableCell
		Private tcDiscont As DevExpress.XtraReports.UI.XRTableCell
        Private nWindDataSet1 As NWindDataSet
        Private productsTableAdapter As NWindDataSetTableAdapters.ProductsTableAdapter
		Private GroupHeaderCategory As DevExpress.XtraReports.UI.GroupHeaderBand
		Private tbCategory As DevExpress.XtraReports.UI.XRTable
		Private trCategory As DevExpress.XtraReports.UI.XRTableRow
		Private tcCategory As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeaderTitle As DevExpress.XtraReports.UI.GroupHeaderBand
		Private tbProductHeader As DevExpress.XtraReports.UI.XRTable
		Private trProductHeader As DevExpress.XtraReports.UI.XRTableRow
		Private tcProductNameHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitPriceHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsInStockHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcUnitsOnOrderHeader As DevExpress.XtraReports.UI.XRTableCell
		Private tcDiscontHeader As DevExpress.XtraReports.UI.XRTableCell
		Private cbDiscont As DevExpress.XtraReports.UI.XRCheckBox
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
