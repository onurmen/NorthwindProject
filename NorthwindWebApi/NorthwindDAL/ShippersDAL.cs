using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
    public class ShippersDAL
    {
        HttpClient client;
        public ShippersDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Shippers> GetAllShippers()
        {
            HttpResponseMessage response = client.GetAsync("api/shippers").Result;
            var result = response.Content.ReadAsAsync<List<Shippers>>().Result;
            return result;

        }
        public Shippers GetShipperById(int id)
        {
            
            HttpResponseMessage response = client.GetAsync("api/shippers/" + id).Result;
            try
            {
                Shippers shippers = response.Content.ReadAsAsync<Shippers>().Result;
                return shippers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CreateShipper(Shippers shippers)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/shippers/", shippers).Result;
            return true;
        }
        public bool UpdateShipper(int id, Shippers shippers)
        {
            HttpResponseMessage response = client.PutAsJsonAsync("api/shippers/" + id.ToString(), shippers).Result;
            return true;
        }
        public bool DeleteShipper(int id)
        {
            HttpResponseMessage response = client.DeleteAsync("api/shippers/" + id.ToString()).Result;
            return true;
        }
    }
}

