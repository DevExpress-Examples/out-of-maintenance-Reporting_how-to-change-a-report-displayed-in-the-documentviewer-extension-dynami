namespace E5020.Reports {
    partial class CategoriesReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nWindDataSet1 = new E5020.Models.NWindDataSet();
            this.categoriesTableAdapter = new E5020.Models.NWindDataSetTableAdapters.CategoriesTableAdapter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDescription,
            this.pbPicture,
            this.lbCategoryName});
            this.Detail.HeightF = 110F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description")});
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(220F, 53.08332F);
            this.lbDescription.Multiline = true;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(430F, 56.91668F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // pbPicture
            // 
            this.pbPicture.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(200F, 100F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName")});
            this.lbCategoryName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(220F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(430F, 32F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.Text = "lbCategoryName";
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Categories Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // CategoriesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.categoriesTableAdapter;
            this.DataMember = "Categories";
            this.DataSource = this.nWindDataSet1;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private Models.NWindDataSet nWindDataSet1;
        private Models.NWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
    }
}
