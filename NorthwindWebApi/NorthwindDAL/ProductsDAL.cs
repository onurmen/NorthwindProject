using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
    public class ProductsDAL
    {
        HttpClient client;
        public ProductsDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Products> GetAllProducts()
        {
            HttpResponseMessage response = client.GetAsync("api/products").Result;
            var result = response.Content.ReadAsAsync<List<Products>>().Result;
            return result;

        }
        public Products GetProductById(int id)
        {
            HttpResponseMessage response = client.GetAsync("api/products/" + id).Result;
            try
            {
                Products products = response.Content.ReadAsAsync<Products>().Result;
                return products;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CreateProduct(Products products)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/products/", products).Result;
            return true;
        }
        public bool UpdateProduct(int id, Products products)
        {
            HttpResponseMessage response = client.PutAsJsonAsync("api/products)/" + id.ToString(), products).Result;
            return true;
        }
        public bool DeleteProduct(int id)
        {
            HttpResponseMessage response = client.DeleteAsync("api/products)/" + id.ToString()).Result;
            return true;
        }
    }
}

