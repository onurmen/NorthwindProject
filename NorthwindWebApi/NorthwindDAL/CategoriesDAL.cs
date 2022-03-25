using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NorthwindEntities;

namespace NorthwindDAL
{
        public class CategoriesDAL
        {
            HttpClient client;
            public CategoriesDAL()
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8088/");
            }
            public IEnumerable<Categories> GetAllCategories()
            {
                HttpResponseMessage categoriesResponse = client.GetAsync("api/categories").Result;
                var result = categoriesResponse.Content.ReadAsAsync<List<Categories>>().Result;
                return result;

            }
            public Categories GetCategoriesById(int id)
            {
                HttpResponseMessage categoriesResponse = client.GetAsync("api/categories/" + id).Result;
                try
                {
                    Categories category = categoriesResponse.Content.ReadAsAsync<Categories>().Result;
                    return category;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public bool CreateCategories(Categories categories)
            {
                HttpResponseMessage categoriesResponse = client.PostAsJsonAsync("api/categories/", categories).Result;
                return true;
            }
            public bool UpdateCategories(int id, Categories categories)
            {
                HttpResponseMessage categoriesResponse = client.PutAsJsonAsync("api/categories/" + id.ToString(), categories).Result;
                return true;
            }
            public bool DeleteCategories(int id)
            {
                HttpResponseMessage categoriesResponse = client.DeleteAsync("api/categories/" + id.ToString()).Result;
                return true;
            }
        }
    }

