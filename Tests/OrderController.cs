using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.model;

namespace Tests
{
    public class OrderController
    {
        Connection connection = new Connection();

        public List<Orders> GetOrders()
        {
            try
            {
                var Orders = connection.auth.Orders.ToList();
                return Orders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Orders CreateNewOrder(int idOrders)
        {

            try
            {
                Orders order = new Orders();
                {
                    idOrder = idOrders;
                };

                connection.auth.Orders.Add(order);
                connection.auth.SaveChanges();
                return order;


            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }


        }
    }
}
