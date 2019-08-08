using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriHalo.Common.Tsurugi;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace TriHalo.API.Service
{
    public class TsurugiService
    {
        public const string BaseURL = "https://localhost:44360/api/Tsurugi";
        private HttpClient Client { get; } = new HttpClient();

        public async Task<Book> PostBook(Book book)
        {
            var url = $"{BaseURL}";
            return await Post(url, book);
        }

        public async Task<List<Book>> GetBooks()
        {
            var url = $"{BaseURL}";
            return await Get<List<Book>>(url);
        }

        public async Task<T> Get<T>(string url)
        {
            var result = await Client.GetAsync(url);
            var a = await Client.GetJsonAsync<T>(url);
            return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
        }

        public async Task<T> Post<T>(string url, T content)
        {
            return await Client.PostJsonAsync<T>(url, content);
        }
    }
}
