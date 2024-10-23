using Restaurant_App.Models;
using Restaurant_App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_App.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDbEntities obj;
        public HomeController()
        {
            obj = new RestaurantDbEntities();
        }

        [HttpGet]
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository(); 
            ItemRepository objItemRepository = new ItemRepository();
            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();
            
            var objectMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objCustomerRepository.GetAllCustomers(), objItemRepository.GetAllItems(),objPaymentTypeRepository.GetAllPaymentType());


            return View(objectMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {

            var item = obj.Items.SingleOrDefault(model => model.ItemId == itemId);

            if (item != null)
            {
                decimal UnitPrice = item.ItemPrice;
                return Json(UnitPrice, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("0.00", JsonRequestBehavior.AllowGet);
            }

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}