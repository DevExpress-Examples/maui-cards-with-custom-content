<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/626853535/24.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1159609)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## .NET MAUI Controls - Cards with Custom Content

This example demonstrates how to turn [DXButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButton) controls into clickable cards with custom content. For example, the bottom card displays a [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView). 

<img width="30%" alt="image" src="https://user-images.githubusercontent.com/12169834/231418620-2f87ae15-69d3-4570-85ce-66807ee4b627.png">

Included controls and their properties:

* [Label](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-7.0): [Text](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.label.text?view=net-maui-7.0)

* [DXButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButton): [Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXBorder.Content), [Clicked](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButtonBase.Clicked)

If a control in a [DXButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButton) intercepts a click, set the control's `InputTransparent` property to `true`. In this case, the control handles clicks instead of the [DXButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButton):
 
```xaml
<dx:DXButton Clicked="Button_Clicked" ...>
    <Grid>
        <views:PageviewsAreaChartView InputTransparent="True"/>
    </Grid>
</dx:DXButton>
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
* [DXButton.Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXBorder.Content)
* [DXButton.Clicked](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButtonBase.Clicked)

## More Examples

* [DevExpress Mobile UI for .NET MAUI](https://github.com/DevExpress-Examples/maui-demo-app/)
