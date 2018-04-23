using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.UI;
using E5020.Reports;
using E5020.Models;

namespace E5020.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ReportModel model = new ReportModel() {
                ReportName = "Categories"
            };
            return View(model);
        }

        public ActionResult ReportCallbackPanelPartial(ReportModel reportModel) {
            return PartialView("_ReportCallbackPanelPartial", reportModel);
        }

        public ActionResult DocumentViewerPartial(ReportModel reportModel) {
            return PartialView("_DocumentViewerPartial", reportModel);
        }

        public ActionResult DocumentViewerExport(ReportModel reportModel) {
            return DocumentViewerExtension.ExportTo(reportModel.CreateReport());
        }
    }
}