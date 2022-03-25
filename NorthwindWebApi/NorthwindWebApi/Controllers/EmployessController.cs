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
    public class EmployessController : ApiController
    {
        // GET: Employess
        static HttpClient client;
        LogService logService = new LogService();
        public EmployessController()
        {
            client.BaseAddress = new Uri("https://northwind.vercel.app/api/");
            logService = new LogService();
        }
        public HttpResponseMessage Get()
        {
            logService.WriteLog("GetEmployess", DateTime.Now);
            var employess = client.GetStringAsync("Employess").Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Employess>>(employess));
        }

        public HttpResponseMessage Get(int id)
        {
            logService.WriteLog("GetEmployess", DateTime.Now);
            var employess = client.GetStringAsync("Employess" + "/" + id).Result;
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.DeserializeObject<IEnumerable<Employess>>(employess));
        }

        public HttpResponseMessage Post(Employess employess)
        {
            logService.WriteLog("PostEmployess", DateTime.Now);
            var employes = client.PostAsJsonAsync("api/Employess/", employess).Result;
            return Request.CreateResponse(HttpStatusCode.Created, employes);
        }

        public HttpResponseMessage Put(int id, Employess employess)
        {
            logService.WriteLog("PutEmployess", DateTime.Now);
            var employes = client.PutAsJsonAsync("api/Employess/" + id.ToString(), employess).Result;
            return Request.CreateResponse(HttpStatusCode.OK, employes);
        }

        public HttpResponseMessage Delete(int id)
        {
            logService.WriteLog("DeleteEmployess", DateTime.Now);
            var employess = client.DeleteAsync("api/Employess/" + id.ToString()).Result;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
