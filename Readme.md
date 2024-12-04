<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578375/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T248625)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WPF - How to apply format conditions to data cells

This example shows how to add format conditions to [WPF Pivot Grid Control](https://docs.devexpress.com/WPF/7228/controls-and-libraries/pivot-grid).

![Pivot Grid](wpf-pivot-cf.png)

The **Data Bar** conditional formatting is applied to the 'Extended Price' measure and intersection of the 'Sales Person' and 'Quarter' fields. This condition formats data cells with a predefined orange gradient data bar. The condition was created in c# code.

The **Top Bottom Rule** conditional formatting is applied to the 'Quantity' measure and intersection of the 'Sales Person' and 'Quarter' fields. This condition formats data cells whose values are above average with green text and light green fill. The condition was created using the [Conditional Formatting Rules Manager](https://docs.devexpress.com/WPF/114038/controls-and-libraries/pivot-grid/data-analysis/conditional-formatting#conditional-formatting-rules-manager).

The **Icon Set** conditional formatting is applied to the 'Extended Price' measure and intersection of the 'Sales Person' and 'Year' fields. This condition displays a specific icon in a cell according to the range to which this cell value belongs. The condition was created using the Conditional Formatting Rules Manager.

## Files to Review

* [MainWindow.xaml](./CS/WpfPivotGridConditionalFormatting/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfPivotGridConditionalFormatting/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfPivotGridConditionalFormatting/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfPivotGridConditionalFormatting/MainWindow.xaml.vb))

## Documentation

* [Conditional Formatting](https://docs.devexpress.com/WPF/114038/controls-and-libraries/pivot-grid/data-analysis/conditional-formatting)
* [Applying Conditional Formatting](https://docs.devexpress.com/WPF/114395/controls-and-libraries/pivot-grid/end-user-capabilities/applying-conditional-formatting)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-apply-format-conditions-to-data-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-apply-format-conditions-to-data-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
