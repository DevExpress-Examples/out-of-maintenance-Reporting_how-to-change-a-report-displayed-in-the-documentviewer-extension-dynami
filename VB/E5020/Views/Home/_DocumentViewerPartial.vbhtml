@ModelType E5020.Models.ReportModel
@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "DocumentViewer"
                                      settings.CallbackRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerPartial",
                                          .ReportName = Model.ReportName
                                      }
                                      settings.ExportRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerExport",
                                          .ReportName = Model.ReportName
                                      }
                                      settings.Report = Model.CreateReport()
                                  End Sub).GetHtml()
