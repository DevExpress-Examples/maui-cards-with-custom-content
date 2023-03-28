using DevExpress.Maui.Charts;
using System.Globalization;

namespace ObjectCard {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private async void AnalyticsItemClicked(object sender, EventArgs e) {
            await DisplayAlert("Clicked", "Navigate to a detail view here", "OK");
        }
    }

}