using ChisoftMobileApp.Models;
using ChisoftMobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChisoftMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        Place mock => DependencyService.Get<Place>();

        public HomePage()
        {
            InitializeComponent();
            getData();
        }

        public async void getData()
        {
            List<PlaceModel> newItem = new List<PlaceModel>();
            newItem = await mock.getplaces();

            myItem.ItemsSource = newItem;
        }

        private void myItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlaceModel myValue = e.CurrentSelection.FirstOrDefault() as PlaceModel;

            App.Current.MainPage.Navigation.PushAsync(new MapPage(myValue));
        }
    }
}