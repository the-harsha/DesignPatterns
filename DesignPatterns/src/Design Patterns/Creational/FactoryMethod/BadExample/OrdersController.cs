using DesignPatterns.src.Design_Patterns.Creational.FactoryMethod.BadExample.BackEndFramework;
using DesignPatterns.src.Design_Patterns.Creational.FactoryMethod.BadExample.TwigView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.FactoryMethod.BadExample
{
    public class OrdersController : Controller
    {
        public void ListOrders()
        {
            // Simulate fetching users previous orders from db
            var orders = new Dictionary<string, object>{
                {"Red socks", "$12.98"},
                {"Black socks", "$12.98"},
                {"Pink T-shirt", "29.00"}
            };

            // Problem: we have to pass the view engine every time we call Render.
            Render("orders.php", orders, new TwigViewEngine());
        }
        public void GetOrder(int id)
        {
            // Simulate getting single order by id from db
            var order = new Dictionary<string, object>{
                {"Red Socks", "$12.98"}
            };

            Render("order.php", order, new TwigViewEngine());
        }
    }
}
