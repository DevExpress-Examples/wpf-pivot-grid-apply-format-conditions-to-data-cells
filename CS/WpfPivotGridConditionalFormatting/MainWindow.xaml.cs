using System.Windows;
using System;
using DevExpress.Xpf.PivotGrid;

namespace WpfPivotGridConditionalFormatting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FilterFieldValues(fieldYear, new int[]{2016}, FieldFilterType.Included);

            // Creates a new DataBarFormatCondition instance.
            DataBarFormatCondition formatRulesDataBar = new DataBarFormatCondition();

            // Adds this instance to the FormatConditionCollection.
            pivotGridControl1.AddFormatCondition(formatRulesDataBar);

            // Specifies a column field.
            formatRulesDataBar.ColumnName = "fieldQuarter";

            // Specifies a row field.
            formatRulesDataBar.RowName = "fieldSalesPerson";

            // Specifies a data field.
            formatRulesDataBar.MeasureName = "fieldExtendedPrice";

            // Applies the condition to intersection of row and column fields.
            formatRulesDataBar.ApplyToSpecificLevel = true;

            // Sets the predefined format.
            formatRulesDataBar.PredefinedFormatName = "OrangeGradientDataBar";

            
        }

        private void FilterFieldValues(PivotGridField field, int[] filterValues, 
            FieldFilterType filterType)
        {
            pivotGridControl1.BeginUpdate();
            try
            {
                field.FilterValues.Clear(); 
                foreach (object filterValue in filterValues)
                    field.FilterValues.Add(filterValue);
            }
            finally
            {
                field.FilterValues.FilterType = filterType;
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
