using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using System.Net.Http;

namespace NewsApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<Root> GetNewsByCategoryAsync(string category)
        {
            string url = $"https://gnews.io/api/v4/top-headlines?category={category}&lang=en&country=us&max=10&apikey=f0eade9d5ded9a4918e4e9244bc07edd";

            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Root>(json);

            return result;
        }
    }
}
