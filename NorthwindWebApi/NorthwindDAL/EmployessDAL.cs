using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
    public class EmployessDAL
    {
        HttpClient client;
        public EmployessDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Employess> GetAllEmployess()
            {
                HttpResponseMessage response = client.GetAsync("api/employess").Result;
                var result = response.Content.ReadAsAsync<List<Employess>>().Result;
                return result;

            }
            public Employess GetEmployessById(int id)
            {
                HttpResponseMessage response = client.GetAsync("api/employess/" + id).Result;
                try
                {
                Employess employess = response.Content.ReadAsAsync<Employess>().Result;
                    return employess;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public bool CreateEmployess(Employess employess)
            {
               HttpResponseMessage response = client.PostAsJsonAsync("api/employess/", employess).Result;
                return true;
            }
            public bool UpdateEmployess(int id, Employess employess)
            {
               HttpResponseMessage response = client.PutAsJsonAsync("api/employess/" + id.ToString(), employess).Result;
                return true;
            }
            public bool DeleteEmployess(int id)
            {
                HttpResponseMessage response = client.DeleteAsync("api/employess/" + id.ToString()).Result;
                return true;
            }
        }
    }

