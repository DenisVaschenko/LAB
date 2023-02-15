using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Factory
    {
        public Factory(string cost1, string cost2, string cost3, string material)
        {
            Cost1 = cost1;
            Cost2 = cost2;
            Cost3 = cost3;
            Material = material;
        }
        void DoOrder(Order order, User user)
        {
            order.Material = Material;
            if(order.Name == "Furniture")
            {
                order.Cost = Cost1;
                user.orders.Add(order);
            }
            else if (order.Name == "Kitchen")
            {
                order.Cost = Cost2;
                user.orders.Add(order);
            }
            else
            {
                order.Cost = Cost3;
                user.orders.Add(order);
            }
        }
        public string Cost1 { get; set; }
        public string Cost2 { get; set; }
        public string Cost3 { get; set; }
        public string Material { get; set; }
    }
}
