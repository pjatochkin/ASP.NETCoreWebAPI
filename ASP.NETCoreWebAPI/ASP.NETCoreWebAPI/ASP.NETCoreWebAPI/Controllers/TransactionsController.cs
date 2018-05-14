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
    public class TransactionsController : Controller
    {
        [HttpGet]
        public JsonResult GetTransactionLogFile()
        {
            List<Transaction> log = Parking.GetParkingInstance().GetTransactionLogFile();
            return Json(log);
        }

        [HttpGet]
        public JsonResult GetTransactionsLastMinute()
        {
            List<Transaction> trn = Parking.GetParkingInstance().allTransaction.Where(t => t._date.AddMinutes(1) == DateTime.Now).ToList<Transaction>();
            return Json(trn);
        }

        [HttpGet]
        public JsonResult GetOneCarTransactions(int idCar)
        {
            List<Transaction> trn = Parking.GetParkingInstance().allTransaction.Where(t => t._date.AddMinutes(1) == DateTime.Now && t._idCar == idCar).ToList<Transaction>();
            return Json(trn);
        }

        [HttpPut]
        public JsonResult AddCarBalance(int idCar, decimal sum)
        {
            Parking.GetParkingInstance().AddCarMoney(idCar, sum);
            return Json(Parking.GetParkingInstance().ReturnCarBalance(idCar));
        }
    }
}
