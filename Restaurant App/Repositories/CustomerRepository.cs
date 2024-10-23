using Restaurant_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_App.Repository
{
    public class CustomerRepository
    {
        RestaurantDbEntities obj;
        public CustomerRepository()
        {
            obj = new RestaurantDbEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from ob in obj.Customers
                                  select new SelectListItem
                                  {
                                      Text = ob.CustomerName,
                                      Value = ob.Id.ToString(),
                                      Selected = true
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}