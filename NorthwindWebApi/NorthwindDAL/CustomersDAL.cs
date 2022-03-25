﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
    public class CustomersDAL
    {
        HttpClient client;
        public CustomersDAL()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
        }
        public IEnumerable<Customers> GetAllCustomers()
        {
            HttpResponseMessage response = client.GetAsync("api/customers").Result;
            var result = response.Content.ReadAsAsync<List<Customers>>().Result;
            return result;

        }
        public Customers GetCustomerById(int id)
        {
            HttpResponseMessage response = client.GetAsync("api/customers/" + id).Result;
            try
            {
                Customers customers = response.Content.ReadAsAsync<Customers>().Result;
                return customers;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CreateCustomer(Customers customers)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/customers/", customers).Result;
            return true;
        }
        public bool UpdateCustomer(int id, Customers customers)
        {
             HttpResponseMessage response = client.PutAsJsonAsync("api/customers/" + id.ToString(), customers).Result;
            return true;
        }
        public bool DeleteCustomer(int id)
        {
            HttpResponseMessage response = client.DeleteAsync("api/customers/" + id.ToString()).Result;
            return true;
        }
    }
}
