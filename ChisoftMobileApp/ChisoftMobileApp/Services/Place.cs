using ChisoftMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChisoftMobileApp.Services
{
    public class Place : IPlace
    {
        List<PlaceModel> myData;
        public Place()
        {
            myData = new List<PlaceModel>();

            myData.Add(new PlaceModel { StallName = "Glasgow Baillieston", Description = "Home Sweet, Home", id = 0, latitute = 55.85004, longitute = -4.11009, ImageUrl = "https://www.s1homes.com/property_images/ABPropertyConsultantsEstateAgents/2019/2019083111504980/image1-640x480.jpg" });
            myData.Add(new PlaceModel { StallName = "Amgen AB", Description = "Gustav III:s Boulevard 54, 169 74 Solna, Sweden", id = 1, latitute = 59.37466, longitute = 18.01249, ImageUrl = "https://6erxg60qvo1qvjha44jrgpan-wpengine.netdna-ssl.com/wp-content/uploads/2016/03/amgen-logo.jpg" });
            myData.Add(new PlaceModel { StallName = "Dawnfresh Seafoods Ltd", Description = "Bothwell Park Industrial Estate, Uddingston, Glasgow G71 6LS", id = 2, latitute = 55.81627, longitute = -4.06965, ImageUrl = "https://www.rutherfordcross.com/wp-content/uploads/sites/6/2017/05/dawnfresh-1.jpg" });
        }
        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}
