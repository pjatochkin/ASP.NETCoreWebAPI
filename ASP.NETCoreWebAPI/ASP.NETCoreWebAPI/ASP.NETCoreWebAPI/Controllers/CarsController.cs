using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETCoreWebAPI.Controllers
{
    [Produces("application/json")]
    public class CarsController : Controller
    {        
        [HttpGet]
        public JsonResult GetAllCars()
        {
            return Json(ClassLibrary.Parking.GetParkingInstance().GetAllCars());
        }

        [HttpGet]
        public JsonResult GetCar(int id)
        {
            return Json(ClassLibrary.Parking.GetParkingInstance().GetOneCar(id));            
        }

        [HttpPost]
        public JsonResult AddCar([FromBody]Car c)
        {
            ClassLibrary.Parking.GetParkingInstance().AddCar(c);
            return Json(c);                
        }
        
        
        [HttpDelete]
        public void Delete(int id)
        {
            ClassLibrary.Parking.GetParkingInstance().RemoveCar(id);
        }
    }
}
