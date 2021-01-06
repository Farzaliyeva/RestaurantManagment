using System;

namespace RestaurantMenecmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuItem1 = new MenuItem(" DR1", "Margarita", 8, Category.drink);
            MenuItem menuItem2 = new MenuItem("DR2", "Blue Lagoon", 10, Category.drink);
            MenuItem menuItem3 = new MenuItem("DR3", " Martinez", 15, Category.drink);
            MenuItem menuItem4 = new MenuItem("DR4", "Old Fashioned", 15, Category.drink);

            MenuItem menuItem5 = new MenuItem("DS1", "Balli tort", 6, Category.desert);
            MenuItem menuItem6 = new MenuItem("DS2", "Tiramisu", 6, Category.desert);
            MenuItem menuItem7 = new MenuItem("DS3", "Vulkan", 7, Category.desert);
            MenuItem menuItem8 = new MenuItem("DS4", " Shokoladli pudinq", 7, Category.desert);

            MenuItem menuItem9 = new MenuItem("SO1", "Mushroom", 5, Category.soup);
            MenuItem menuItem10 = new MenuItem("SO2", "Vegetable", 6, Category.soup);
            MenuItem menuItem11 = new MenuItem("SO3", "Chicken", 8, Category.soup);
            MenuItem menuItem12 = new MenuItem("SO4", "Tomato", 6, Category.soup);

            MenuItem menuItem13 = new MenuItem("BR1", "Hamburger", 9, Category.mainfood);
            MenuItem menuItem14 = new MenuItem("BR2", "Chicken", 8, Category.mainfood);
            MenuItem menuItem15 = new MenuItem("BR3", "Vegeterian", 10, Category.mainfood);
            MenuItem menuItem16 = new MenuItem("BR4", "Cheeseburger", 5, Category.mainfood);

            Console.WriteLine($"{menuItem1.No}-{menuItem1.Name}-{menuItem1.Price}-{menuItem1.Category}");
            Console.WriteLine($"{menuItem2.No}-{menuItem2.Name}-{menuItem2.Price}-{menuItem2.Category}");
            Console.WriteLine($"{menuItem3.No}-{menuItem3.Name}-{menuItem3.Price}-{menuItem3.Category}");
            Console.WriteLine($"{menuItem4.No}-{menuItem4.Name}-{menuItem4.Price}-{menuItem4.Category}");

            Console.WriteLine($"{menuItem5.No}-{menuItem5.Name}-{menuItem5.Price}-{menuItem5.Category}");
            Console.WriteLine($"{menuItem6.No}-{menuItem6.Name}-{menuItem6.Price}-{menuItem6.Category}");
            Console.WriteLine($"{menuItem7.No}-{menuItem7.Name}-{menuItem7.Price}-{menuItem7.Category}");
            Console.WriteLine($"{menuItem8.No}-{menuItem8.Name}-{menuItem8.Price}-{menuItem8.Category}");


            Console.WriteLine($"{menuItem9.No}-{menuItem9.Name}-{menuItem9.Price}-{menuItem9.Category}");
            Console.WriteLine($"{menuItem10.No}-{menuItem10.Name}-{menuItem10.Price}-{menuItem10.Category}");
            Console.WriteLine($"{menuItem11.No}-{menuItem11.Name}-{menuItem11.Price}-{menuItem11.Category}");
            Console.WriteLine($"{menuItem12.No}-{menuItem12.Name}-{menuItem12.Price}-{menuItem12.Category}");
            Console.WriteLine($"{menuItem13.No}-{menuItem13.Name}-{menuItem13.Price}-{menuItem13.Category}");
            Console.WriteLine($"{menuItem14.No}-{menuItem14.Name}-{menuItem14.Price}-{menuItem14.Category}");
            Console.WriteLine($"{menuItem15.No}-{menuItem15.Name}-{menuItem15.Price}-{menuItem15.Category}");
            Console.WriteLine($"{menuItem16.No}-{menuItem16.Name}-{menuItem16.Price}-{menuItem16.Category}");

        }
    }
}















          
