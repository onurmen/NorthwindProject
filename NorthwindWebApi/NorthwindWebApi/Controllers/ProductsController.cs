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
    public class ProductsController : ApiController
    {
        // GET: Products
        static HttpClient client;
        LogService logService = new LogService();
        public ProductsController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetProducts", DateTime.Now);
            var product = client.GetStringAsync("Products").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Products>>(product));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetProducts", DateTime.Now);
            var product = client.GetStringAsync("Products" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Products>>(product));
        }

        public HttpResponseMessage Post(Products products)
        {
            logService.WriteLog("PostProducts", DateTime.Now);
            var product = client.PostAsJsonAsync("api/Products/", products).Result;
            return Request.CreateResponse(HttpStatusCode.Created, product);
        }

        public HttpResponseMessage Put(int id, Products products)
        {
            logService.WriteLog("PutProducts", DateTime.Now);
            var product = client.PutAsJsonAsync("api/Products/" + id.ToString(), products).Result;
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteProducts", DateTime.Now);
            var product = client.DeleteAsync("api/Products/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}