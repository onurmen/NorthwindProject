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
    public class ShippersController : ApiController
    {
        // GET: Shippers
        static HttpClient client;
        LogService logService = new LogService();
        public ShippersController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetShippers", DateTime.Now);
            var shipper = client.GetStringAsync("Shippers").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Shippers>>(shipper));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetShippers", DateTime.Now);
            var shipper = client.GetStringAsync("Shippers" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Shippers>>(shipper));
        }

        public HttpResponseMessage Post(Shippers shippers)
        {
            logService.WriteLog("PostShippers", DateTime.Now);
            var shipper = client.PostAsJsonAsync("api/Shippers/", shippers).Result;
            return Request.CreateResponse(HttpStatusCode.Created, shipper);
        }

        public HttpResponseMessage Put(int id, Shippers shippers)
        {
            logService.WriteLog("PutShippers", DateTime.Now);
            var shipper = client.PutAsJsonAsync("api/Shippers/" + id.ToString(), shippers).Result;
            return Request.CreateResponse(HttpStatusCode.OK, shipper);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteShippers", DateTime.Now);
            var shipper = client.DeleteAsync("api/Shippers/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}