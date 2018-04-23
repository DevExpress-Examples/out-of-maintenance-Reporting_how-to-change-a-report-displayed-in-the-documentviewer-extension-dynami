using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.UI;
using E5020.Reports;

namespace E5020.Models {
    public class ReportModel {
        public string ReportName {
            get;
            set;
        }

        public XtraReport CreateReport() {
            switch (ReportName) {
                case "Categories":
                    return new CategoriesReport();
                case "Products":
                    return new ProductsReport();
                case "Orders":
                    return new OrdersReport();
            }
            return null;
        }
    }
}