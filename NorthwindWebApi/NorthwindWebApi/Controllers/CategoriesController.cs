using LogLibrary;
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
    public class CategoriesController : ApiController
    {
        // GET: Categories
        static HttpClient client;
        LogService logService = new LogService();
        public CategoriesController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetCustomers", DateTime.Now);
            var customer = client.GetStringAsync("Customers").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Categories>>(customer));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetCustomers", DateTime.Now);
            var customer = client.GetStringAsync("Customers" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Categories>>(customer));
        }

        public HttpResponseMessage Post(Customers customers)
        {
            logService.WriteLog("PostCustomers", DateTime.Now);
            var customer = client.PostAsJsonAsync("api/Customers/", customers).Result;
            return Request.CreateResponse(HttpStatusCode.Created, customer);
        }

        public HttpResponseMessage Put(int id, Customers customers)
        {
            logService.WriteLog("PutCustomers", DateTime.Now);
            var customer = client.PutAsJsonAsync("api/Customers/" + id.ToString(), customers).Result;
            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteCustomers", DateTime.Now);
            var customer = client.DeleteAsync("api/Customers/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}