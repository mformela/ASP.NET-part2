using Fuel_zad_domowe.BusinessLogic;
using Fuel_zad_domowe.Models;
using Fuel_zad_domowe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fuel_zad_domowe.Controllers
{
    public class FuelController : Controller
    {
        /*piszemy tutaj contructor dla BL*/
        private readonly FuelBusinessLogic _businessLogic;

        public FuelController()
        {
            _businessLogic = new FuelBusinessLogic();
        }


        // GET: Fuel
        public ActionResult Index()
        {
            var model = new FuelViewModel { FuelModel = new FuelModel() }; //musimy to dodać, żeby nam się uruchomiło//
            return View("View", model); /*odwołujemy się tutaj do widoku*/
        }

        [HttpPost]
        public ActionResult FuelCalculate(FuelViewModel model)
        {
            //1) fuel model moze być nullem, więc dodajemy warunek, że musi być różne od null i distance różne od 0
          if(model.FuelModel != null && model.FuelModel.Distance != 0)
            {
                model.FuelModel.AvgConsumption =
                    _businessLogic.CalvulateAvgConsumption(model.FuelModel.Fuel, model.FuelModel.Distance);
                model.ShowResult = true;
                return View("View", model);
            }
            model.ShowResult = false;
            ViewBag.ERROR = "błędne dane";
            return View("View", model);
        }
    }
}