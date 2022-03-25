using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindEntities;
using System.Net.Http;

namespace NorthwindDAL
{
    public class OrderDAL
    {
        HttpClient client;
        public OrderDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Orders> GetAllOrders()
        {
            HttpResponseMessage response = client.GetAsync("api/orders").Result;
            var result = response.Content.ReadAsAsync<List<Orders>>().Result;
            return result;

        }
        public Orders GetOrdersById(int id)
        {
            HttpResponseMessage response = client.GetAsync("api/orders/" + id).Result;
            try
            {
                Orders orders = response.Content.ReadAsAsync<Orders>().Result;
                return orders;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CreateOrders(Orders orders)
        {
           HttpResponseMessage response = client.PostAsJsonAsync("api/orders/", orders).Result;
            return true;
        }
        public bool UpdateOrders(int id, Orders orders)
        {
             HttpResponseMessage response = client.PutAsJsonAsync("api/orders/" + id.ToString(), orders).Result;
            return true;
        }
        public bool DeleteOrders(int id)
        {
            HttpResponseMessage response = client.DeleteAsync("api/orders/" + id.ToString()).Result;
            return true;
        }
    }
}
