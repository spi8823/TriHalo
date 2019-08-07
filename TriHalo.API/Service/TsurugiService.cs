using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using TriHalo.Common.Tsurugi;
//using Newtonsoft.Json;

namespace TriHalo.API.Service
{
    public class TsurugiService
    {
        public const string BaseURL = "/api/Tsurugi";
        private HttpClient Client { get; } = new HttpClient();

        public async Task<int> PostBook(Book book)
        {
            var url = $"{BaseURL}/";
            return 1;
        }
    }
}
