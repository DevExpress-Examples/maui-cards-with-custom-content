<!-- default badges list -->
<!-- default badges end -->
## Cards with Custom Content

This example shows how to display a [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) and [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView) controls within cards. These cards can implement any required actions.  

<img src="https://user-images.githubusercontent.com/12169834/228201579-826dea6c-4af0-4bdc-ae86-4873cd115fd6.png" width="30%"/>

Used controls and their properties:

* [Label](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-7.0): [Text](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.label.text?view=net-maui-7.0)

* [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton): [Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Content), [Clicked](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Clicked)

If a control within the [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) intercepts a click, set the control's `InputTransparent` property to `true`:
 
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
