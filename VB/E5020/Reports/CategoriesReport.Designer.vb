Imports Microsoft.VisualBasic
Imports System
Namespace E5020.Reports
	Partial Public Class CategoriesReport
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
			Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
			Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nWindDataSet1 = New NWindDataSet()
            Me.categoriesTableAdapter = New NWindDataSetTableAdapters.CategoriesTableAdapter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
			Me.Detail.HeightF = 110F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220F, 53.08332F)
			Me.lbDescription.Multiline = True
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(430F, 56.91668F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(430F, 32F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.Text = "lbCategoryName"
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
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Categories Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' CategoriesReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nWindDataSet1
			Me.Version = "13.2"
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private nWindDataSet1 As NWindDataSet
        Private categoriesTableAdapter As NWindDataSetTableAdapters.CategoriesTableAdapter
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
