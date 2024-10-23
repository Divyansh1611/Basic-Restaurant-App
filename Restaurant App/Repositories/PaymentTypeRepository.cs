using Restaurant_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_App.Repository
{
    public class PaymentTypeRepository
    {
        RestaurantDbEntities obj;
        public PaymentTypeRepository()
        {
            obj = new RestaurantDbEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from ob in obj.Payments
                                  select new SelectListItem
                                  {
                                      Text = ob.PaymentTypeName,
                                      Value = ob.PaymentTypeid.ToString(),
                                      Selected = true
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}