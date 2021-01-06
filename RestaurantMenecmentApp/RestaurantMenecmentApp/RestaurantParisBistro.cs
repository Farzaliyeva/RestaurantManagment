using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenecmentApp
{
    class RestaurantParisBistro : IRestaurantManager

    {
        public List<MenuItem> menuitems { get; set; }
        public List<Orders> orders { get; set; }

        public void AddMenuItem(string name, double price, Category category)
        {
            
        }

        public void AddOrder(MenuItem  menuItem ,int count)
        {
            
        }

        public void EditMenuItem(string name, double price, string no)
        {
           
        }

        public List<Orders> GetOrdersByDate(DateTime date)
        {
          
        }

        public Orders GetOrdersByNo(string No)
        {
            
        }

        public List<OrderItem> GetOrdersByPriceInterval(double price, double price1)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSearch(string Information)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSortByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> MenuItemsSortByPrice(double price, double price1)
        {
            throw new NotImplementedException();
        }

        public void RemoveMenuItem(string name, double price, string no)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int no)
        {
            throw new NotImplementedException();
        }
    }
}
