Imports System.Windows
Imports System
Imports DevExpress.Xpf.PivotGrid

Namespace WpfPivotGridConditionalFormatting
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            FilterFieldValues(fieldYear, New Integer(){2016}, FieldFilterType.Included)

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

        Private Sub FilterFieldValues(ByVal field As PivotGridField,
                                      ByVal filterValues() As Integer,
                                      ByVal filterType As FieldFilterType)
            pivotGridControl1.BeginUpdate()
            Try
                field.FilterValues.Clear()
                For Each filterValue As Object In filterValues
                    field.FilterValues.Add(filterValue)
                Next filterValue
            Finally
                field.FilterValues.FilterType = filterType
                pivotGridControl1.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
