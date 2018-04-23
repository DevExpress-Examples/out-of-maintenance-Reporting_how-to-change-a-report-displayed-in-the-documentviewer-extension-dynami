@ModelType E5020.Models.ReportModel
@Code
    ViewBag.Title = "Home Page"
End Code

<script type="text/javascript">
    function ReportsComboBox_SelectedIndexChanged(s, e) {
        ReportCallbackPanel.PerformCallback({ ReportName: s.GetValue() })
    }
</script>

@Html.DevExpress().Label(Sub(settings)
                             settings.Name = "Label"
                             settings.AssociatedControlName = "ReportsComboBox"
                             settings.Text = "Select Report:"
                         End Sub).GetHtml()
@Html.DevExpress().ComboBox(Sub(settings)
                                settings.Name = "ReportsComboBox"
                                settings.Properties.ClientSideEvents.SelectedIndexChanged = "ReportsComboBox_SelectedIndexChanged"

                                settings.Properties.Items.Add("Categories")
                                settings.Properties.Items.Add("Products")
                                settings.Properties.Items.Add("Orders")
                            End Sub).Bind(Model.ReportName).GetHtml()

@Html.Action("ReportCallbackPanelPartial", Model)
