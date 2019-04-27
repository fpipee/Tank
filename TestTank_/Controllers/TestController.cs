using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestTank_.Models;

namespace TestTank_.Controllers
{
    public class TestController : Controller
    {
        dbTankEntities dbTsnk = new dbTankEntities();

        // GET: Test
        public ActionResult Index()
        {
         
            var datos = (from x in dbTsnk.TableTank
                       where x.id == 1
                       select x).ToList();
            obtabletank ModelData = new obtabletank();
            ModelData.id = datos[0].id;

            ModelData.liquidCapacity = datos[0].liquidCapacity;
            ModelData.liquidCapacityMin = datos[0].liquidCapacityMin;
            ModelData.liquidCapacityMax = datos[0].liquidCapacityMax;
            ModelData.tankCapacity = datos[0].liquidCapacityMax;
            ModelData.tankCapacityMax = datos[0].tankCapacityMax;
            ModelData.tankCapacityMin = datos[0].tankCapacityMin;

            return View(ModelData);
               // return View["ViewItem"] = datos;
        }

       

        // GET: Test/Edit/5
        public ActionResult EditLiquid(int id)
        {
            var result = dbTsnk.TableTank.SingleOrDefault(b => b.id == 1);
            if (result != null)
            {
                result.liquidCapacity = id;
                dbTsnk.SaveChanges();
            }
            return View();
        }


        // GET: Test/Edit/5
        public ActionResult EditDataSetting(int valMin, int valMax, int valAlertMax, int valAlertMin)
        {
            var result = dbTsnk.TableTank.SingleOrDefault(b => b.id == 1);
            if (result != null)
            {
                result.liquidCapacityMax = valAlertMax;
                result.liquidCapacityMin = valAlertMin;

                result.tankCapacityMax = valMax;
                result.tankCapacityMin = valMin;

                dbTsnk.SaveChanges();
            }
            return View();
        }
        

     
    }
}
