using Restaurant_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_App.Repository
{
    public class ItemRepository
    {
        RestaurantDbEntities obj;
        public ItemRepository()
        {
            obj = new RestaurantDbEntities();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from ob in obj.Items
                                  select new SelectListItem
                                  {
                                      Text = ob.ItemName,
                                      Value = ob.ItemId.ToString(),
                                      Selected = false
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}