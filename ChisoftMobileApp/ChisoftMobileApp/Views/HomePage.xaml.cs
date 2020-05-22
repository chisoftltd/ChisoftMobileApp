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
        IPlace mock => DependencyService.Get<IPlace>();

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
    }
}