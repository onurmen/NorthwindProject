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
    public class SuppliersController : ApiController
    {
        // GET: Suppliers
        static HttpClient client;
        LogService logService = new LogService();
        public SuppliersController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetSuppliers", DateTime.Now);
            var supplier = client.GetStringAsync("Suppliers").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Suppliers>>(supplier));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetSuppliers", DateTime.Now);
            var supplier = client.GetStringAsync("Suppliers" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Categories>>(supplier));
        }

        public HttpResponseMessage Post(Suppliers suppliers)
        {
            logService.WriteLog("PostSuppliers", DateTime.Now);
            var supplier = client.PostAsJsonAsync("api/Suppliers/", suppliers).Result;
            return Request.CreateResponse(HttpStatusCode.Created, supplier);
        }

        public HttpResponseMessage Put(int id, Suppliers suppliers)
        {
            logService.WriteLog("PutSuppliers", DateTime.Now);
            var supplier = client.PutAsJsonAsync("api/Suppliers/" + id.ToString(), suppliers).Result;
            return Request.CreateResponse(HttpStatusCode.OK, supplier);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteSuppliers", DateTime.Now);
            var supplier = client.DeleteAsync("api/Suppliers/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}