using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuel_zad_domowe.BusinessLogic
{
    public class FuelBusinessLogic
    {

        //tworzona jest tutaj logika biznesowa, żeby obliczyć średnie zużycie paliwa - rozbijamy to na dwie części 
        public double CalvulateAvgConsumption (int fuel, int distance)
        {
            double avg = (double)fuel / distance;
            return avg * 100;
        }
    

    }
}