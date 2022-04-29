Imports System.Windows
Imports System
Imports DevExpress.Xpf.PivotGrid
Imports nwindDataSetTableAdapters

Namespace WpfPivotGridConditionalFormatting
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window
        Private salesPersonDataTable As New nwindDataSet.SalesPersonDataTable()
        Private salesPersonDataAdapter As New SalesPersonTableAdapter()
        Public Sub New()
            InitializeComponent()
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            pivotGridControl1.DataSource = salesPersonDataTable


            ' Creates a new DataBarFormatCondition instance.
            Dim formatRulesDataBar As New DataBarFormatCondition()

            ' Adds this instance to the FormatConditionCollection.
            pivotGridControl1.AddFormatCondition(formatRulesDataBar)

            ' Specifies a column field.
            formatRulesDataBar.ColumnName = "fieldQuarter"

            ' Specifies a row field.
            formatRulesDataBar.RowName = "fieldSalesPerson"

            ' Specifies a data field.
            formatRulesDataBar.MeasureName = "fieldExtendedPrice"

            ' Applies the condition to intersection of row and column fields.
            formatRulesDataBar.ApplyToSpecificLevel = True

            ' Sets the predefined format.
            formatRulesDataBar.PredefinedFormatName = "OrangeGradientDataBar"


        End Sub
    End Class
End Namespace
