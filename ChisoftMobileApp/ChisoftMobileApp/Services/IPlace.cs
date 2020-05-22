using ChisoftMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChisoftMobileApp.Services
{
    public interface IPlace
    {
        Task<List<PlaceModel>> getplaces();
    }
}
