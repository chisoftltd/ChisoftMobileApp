using ChisoftMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
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

            Position position = new Position(myValue.latitute, myValue.longitute);
            MapSpan mapSpan = new MapSpan(position, 0.1, 0.1);
            Map MyMap = new Map(mapSpan);

            Pin pin = new Pin
            {
                Position = new Position(myValue.latitute, myValue.longitute),
                Label = myValue.StallName,
                Address = myValue.Description
            };

            MyMap.IsShowingUser = true;

            MyMap.Pins.Add(pin);
            contanier.Children.Add(MyMap);
        }
    }
}