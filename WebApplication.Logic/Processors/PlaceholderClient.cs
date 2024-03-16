using Miha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Processors
{
    public class PlaceholderClient : IPlaceholderClient
    {
        private readonly string _baseUrl;

        public PlaceholderClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public async Task<List<User>> GetUser(string name)
        {
            return await GetData<User>("users");
        }

        private async Task<List<TData>> GetData<TData>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage message = new HttpRequestMessage();
                message.RequestUri = new Uri($"{_baseUrl}/{path}");
                message.Method = HttpMethod.Get;

                HttpResponseMessage response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    string dataString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<TData>>(dataString);
                }
                return new List<TData>();
            }
        }
    }
}
