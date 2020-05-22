using ChisoftMobileApp.Models;
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
    public partial class MapPage : ContentPage
    {

        PlaceModel myValue = new PlaceModel();
        public MapPage(PlaceModel place)
        {
            InitializeComponent();
            myValue = place;
        }
    }
}