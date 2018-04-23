namespace E5020.Reports {
    partial class OrdersReport {
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
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDetails = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.lbShipTo = new DevExpress.XtraReports.UI.XRLabel();
            this.lbOrderID = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.nWindDataSet1 = new E5020.Models.NWindDataSet();
            this.ordersTableAdapter = new E5020.Models.NWindDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDate,
            this.lbDetails,
            this.lbTitle,
            this.lbShipTo,
            this.lbOrderID});
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDate
            // 
            this.lbDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Orders.OrderDate", "{0:dddd, dd MMMM, yyyy}")});
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic);
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(101.6667F, 10.00001F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(238.3334F, 23F);
            this.lbDate.StylePriority.UseFont = false;
            this.lbDate.Text = "lbDate";
            // 
            // lbDetails
            // 
            this.lbDetails.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 67.00001F);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDetails.SizeF = new System.Drawing.SizeF(330F, 32.99999F);
            this.lbDetails.StylePriority.UseTextAlignment = false;
            this.lbDetails.Text = "[FirstName] [LastName]";
            this.lbDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Orders.Title")});
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(10.00012F, 44.00002F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(330F, 23F);
            this.lbTitle.StylePriority.UseFont = false;
            this.lbTitle.StylePriority.UseTextAlignment = false;
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // lbShipTo
            // 
            this.lbShipTo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbShipTo.LocationFloat = new DevExpress.Utils.PointFloat(352.5F, 10.00001F);
            this.lbShipTo.Multiline = true;
            this.lbShipTo.Name = "lbShipTo";
            this.lbShipTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbShipTo.SizeF = new System.Drawing.SizeF(287.5F, 89.99999F);
            this.lbShipTo.StylePriority.UseFont = false;
            this.lbShipTo.Text = "Ship To [ContactName] ([CompanyName]):\r\n[ShipCountry], [ShipCity] [ShipPostalCode" +
    "]\r\n[ShipRegion]\r\n[ShipAddress]";
            // 
            // lbOrderID
            // 
            this.lbOrderID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Orders.OrderID")});
            this.lbOrderID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbOrderID.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOrderID.SizeF = new System.Drawing.SizeF(91.66666F, 23F);
            this.lbOrderID.StylePriority.UseFont = false;
            this.lbOrderID.Text = "lbOrderID";
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
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Orders Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.ordersTableAdapter;
            this.DataMember = "Orders";
            this.DataSource = this.nWindDataSet1;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
        private Models.NWindDataSet nWindDataSet1;
        private Models.NWindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private DevExpress.XtraReports.UI.XRLabel lbDetails;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.XRLabel lbShipTo;
        private DevExpress.XtraReports.UI.XRLabel lbOrderID;
    }
}
