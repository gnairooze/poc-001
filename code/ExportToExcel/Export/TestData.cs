using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    internal class TestData
    {
        public static List<Order> CreateOrders()
        {
            List<Order> orders =
            [
                new Order
                {
                    OrderId = 1,
                    Item = "Widget",
                    Units = 10,
                    Price = 2.99,
                    OrderDate = new DateTime(2021, 1, 1),
                    SalesAssociate = "John Doe",
                    Delivered = true
                },
                new Order
                {
                    OrderId = 2,
                    Item = "Gadget",
                    Units = 5,
                    Price = 4.99,
                    OrderDate = new DateTime(2021, 1, 2),
                    SalesAssociate = "Jane Doe",
                    Delivered = false
                }
            ];

            return orders;
        }

        public static List<Inventory> CreateInventoryList()
        {
            List<Inventory> inventoryList = [
                new Inventory
                {
                    ItemId = 1,
                    Item = "Widget",
                    Number = 100,
                    Price = 2.99
                },
                new Inventory
                {
                    ItemId = 2,
                    Item = "Gadget",
                    Number = 50,
                    Price = 4.99
                }
            ];

            return inventoryList;
        }
    }
}
