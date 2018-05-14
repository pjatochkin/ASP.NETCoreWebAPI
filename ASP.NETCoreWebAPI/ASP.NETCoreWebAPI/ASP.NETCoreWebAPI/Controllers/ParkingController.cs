using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETCoreWebAPI.Controllers
{
    [Produces("application/json")]
    public class ParkingController : Controller
    {
        [HttpGet]
        public JsonResult GetNumberOfFreeParkingSpaces()
        {
            return Json(ClassLibrary.Settings.GetSettingsInstance()._parkingSpace - ClassLibrary.Parking.GetParkingInstance().ReturnCarsCount());
        }
                
        [HttpGet]
        public JsonResult GetNumberOfBusyPlacesInParkingLot()
        {
            return Json(ClassLibrary.Parking.GetParkingInstance().ReturnCarsCount());
        }

        [HttpGet]
        public JsonResult GetTotalRevenueParking()
        {
            return Json(ClassLibrary.Parking.GetParkingInstance()._allMoney);
        }        
    }
}
