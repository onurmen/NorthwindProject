using Newtonsoft.Json;
using NorthwindDAL;
using NorthwindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NorthwindWebApi.Controllers
{
    public class CustomersController : ApiController
    {
        static HttpClient client;
        public CustomersController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
        }
        public HttpResponseMessage Get()
        {
            var customer = client.GetStringAsync("Customers").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Categories>>(customer));
        }

        public HttpResponseMessage Get(int id)
        {
            var customer = client.GetStringAsync("Customers" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Categories>>(customer));
        }

        public HttpResponseMessage Post(Customers customers)
        {
            var customer = client.PostAsJsonAsync("api/Customers/", customers).Result;
            return Request.CreateResponse(HttpStatusCode.Created, customer);
        }

        public HttpResponseMessage Put(int id, Customers customers)
        {
            var customer = client.PutAsJsonAsync("api/Customers/" + id.ToString(), customers).Result;
            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        public HttpResponseMessage Delete(int id)
        {
            var customer = client.DeleteAsync("api/customers/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
