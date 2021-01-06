using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenecmentApp
{
    public  class OrderItem
    {
        public string MenuItem { get; set; }
        public double Count { get; set; }



        public OrderItem (string menuitem,double count)
        {
            this.Count = count;
            this.MenuItem = MenuItem;
        }
        
          
    }
}
