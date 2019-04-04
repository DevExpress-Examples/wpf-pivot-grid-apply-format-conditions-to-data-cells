<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfPivotGridConditionalFormatting/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfPivotGridConditionalFormatting/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfPivotGridConditionalFormatting/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfPivotGridConditionalFormatting/MainWindow.xaml.vb))
<!-- default file list end -->
# How to apply format conditions to pivot grid data cells


This example shows how to add format conditions to <a href="https://documentation.devexpress.com/#WPF/CustomDocument7228">WPF Pivot Grid Control</a>.<br>The Data Bar conditional formatting is applied to the 'Extended Price' measure and intersection of the 'Sales Person' and 'Quarter' fields. This condition formats data cells with a predefined orange gradient data bar. The condition was created in c# code.<br>The Top Bottom Rule conditional formatting is applied to the 'Quantity' measure and intersection of the 'Sales Person' and 'Quarter' fields. This condition formats data cells whose values are above average with green text and light green fill. The condition was created using the <a href="https://documentation.devexpress.devx/#WPF/CustomDocument114038/">Conditional Formatting Rules Manager</a>.<br>The Icon Set conditional formatting is applied to the 'Extended Price' measure and intersection of the 'Sales Person' and 'Year' fields. This condition displays a specific icon in a cell according to the range to which this cell value belongs. The condition was created using the Conditional Formatting Rules Manager.

<br/>


