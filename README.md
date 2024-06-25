<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/626853535/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1159609)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
## .NET MAUI Controls - Cards with Custom Content

This example demonstrates how to turn [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) controls into clickable cards with custom content. For example, the bottom card displays a [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView). 

<img width="30%" alt="image" src="https://user-images.githubusercontent.com/12169834/231418620-2f87ae15-69d3-4570-85ce-66807ee4b627.png">

Included controls and their properties:

* [Label](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-7.0): [Text](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.label.text?view=net-maui-7.0)

* [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton): [Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Content), [Clicked](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Clicked)

If a control in a [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) intercepts a click, set the control's `InputTransparent` property to `true`. In this case, the control handles clicks instead of the [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton):
 
```xaml
<dxco:SimpleButton Clicked="SimpleButton_Clicked" ...>
    <Grid>
        <views:PageviewsAreaChartView InputTransparent="True"/>
    </Grid>
</dxco:SimpleButton>
```

## Files to Look At

<!-- default file list -->
* [MainPage.xaml](CS/MainPage.xaml)
* [ChannelsDonutView.xaml](CS/Views/ChannelsDonutView.xaml)
* [PageviewsAreaChartView.xaml](CS/Views/PageviewsAreaChartView.xaml)
* [ChannelDonutViewModel.cs](CS/ViewModels/ChannelDonutViewModel.cs)
* [PageviewsAreaChartViewModel.cs](CS/ViewModels/PageviewsAreaChartViewModel.cs)
* [App.xaml](CS/App.xaml)
<!-- default file list end -->

## Documentation

* [Featured Scenario: Cards with Custom Content](https://docs.devexpress.com/MAUI/404341)
* [Featured Scenarios](https://docs.devexpress.com/MAUI/404291)
* [SimpleButton.Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Content)
* [SimpleButton.Clicked](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Clicked)

## More Examples

* [DevExpress Mobile UI for .NET MAUI](https://github.com/DevExpress-Examples/maui-demo-app/)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=maui-cards-with-custom-content&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=maui-cards-with-custom-content&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
