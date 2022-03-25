using Newtonsoft.Json;
using NorthwindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace NorthwindWebApi
{
    public class NorthwindService
    {
        static HttpClient client;
        static NorthwindService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
        }
        public IEnumerable<Categories> GetCategories()
        {
            var response = client.GetStringAsync("Categories").Result;
            return JsonConvert.DeserializeObject<IEnumerable<Categories>>(response);
        }

        public IEnumerable<Categories> GetCategoriesA()
        {
            var response = client.GetStringAsync("Categories").Result;
            return JsonConvert.DeserializeObject<IEnumerable<Categories>>(response);
        }
    }
}