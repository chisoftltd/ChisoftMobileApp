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

            myData.Add(new PlaceModel { StallName = "McDonalds", Description = "World leading fast food gaint", id = 0, latitute = 1215.065, longitute = 101.0564, ImageUrl = "https://images.pexels.com/photos/1858115/pexels-photo-1858115.jpeg" });
            myData.Add(new PlaceModel { StallName = "ASDA", Description = "UK leading grocery store", id = 1, latitute = 1615.065, longitute = 101.0564, ImageUrl = "https://images.pexels.com/photos/4621/fruits-grocery-bananas-market.jpg" });
            myData.Add(new PlaceModel { StallName = "Lidl", Description = "United Kingdom discount grocery store.", id = 2, latitute = 2215.065, longitute = 101.0564, ImageUrl = "https://images.pexels.com/photos/2292919/pexels-photo-2292919.jpeg" });
        }
        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}
