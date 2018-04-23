@ModelType E5020.Models.ReportModel
@Html.DevExpress().CallbackPanel(Sub(settings)
                                     settings.Name = "ReportCallbackPanel"
                                     settings.CallbackRouteValues = New With {
                                         .Controller = "Home",
                                         .Action = "ReportCallbackPanelPartial",
                                                                           .ReportName = Model.ReportName
                                     }
                                     settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                     settings.Height = 800

                                     settings.SetContent(Sub()
                                                             Html.RenderAction("DocumentViewerPartial", Model)
                                                         End Sub)
                                 End Sub).GetHtml()
