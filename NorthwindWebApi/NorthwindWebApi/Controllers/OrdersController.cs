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
    public class OrdersController : ApiController
    {
        // GET: Orders
        static HttpClient client;
        LogService logService = new LogService();
        public OrdersController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetOrders", DateTime.Now);
            var order = client.GetStringAsync("Orders").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Orders>>(order));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetOrders", DateTime.Now);
            var order = client.GetStringAsync("Orders" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Orders>>(order));
        }

        public HttpResponseMessage Post(Orders orders)
        {
            logService.WriteLog("PostOrders", DateTime.Now);
            var order = client.PostAsJsonAsync("api/Orders/", orders).Result;
            return Request.CreateResponse(HttpStatusCode.Created, order);
        }

        public HttpResponseMessage Put(int id, Orders orders)
        {
            logService.WriteLog("PutCustomers", DateTime.Now);
            var order = client.PutAsJsonAsync("api/Orders/" + id.ToString(), orders).Result;
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteOrders", DateTime.Now);
            var order = client.DeleteAsync("api/Orders/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}