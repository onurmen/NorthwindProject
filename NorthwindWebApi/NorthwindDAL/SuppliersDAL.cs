using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
    public class SuppliersDAL
    {
        HttpClient client;
        public SuppliersDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Suppliers> GetAllSuppliers()
        {
             HttpResponseMessage response = client.GetAsync("api/suppliers").Result;
            var result = response.Content.ReadAsAsync<List<Suppliers>>().Result;
            return result;

        }
        public Suppliers GetSupplierById(int id)
        {
            HttpResponseMessage response = client.GetAsync("api/suppliers/" + id).Result;
            try
            {
                Suppliers suppliers = response.Content.ReadAsAsync<Suppliers>().Result;
                return suppliers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CreateSupplier(Suppliers suppliers)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/suppliers/", suppliers).Result;
            return true;
        }
        public bool UpdateSuppliers(int id, Suppliers suppliers)
        {
            HttpResponseMessage response = client.PutAsJsonAsync("api/suppliers/" + id.ToString(), suppliers).Result;
            return true;
        }
        public bool DeleteSuppliers(int id)
        {
             HttpResponseMessage response = client.DeleteAsync("api/suppliers/" + id.ToString()).Result;
            return true;
        }
    }
}
