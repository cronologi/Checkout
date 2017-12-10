using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Infrastructure.Network
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private HttpClient _client;

        public HttpClientWrapper(HttpClient client)
        {
            _client = client;
        }

        public void Post(string address, string json)
        {
            _client.BaseAddress = new Uri(address);
            _client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "relativeAddress");
            request.Content = new StringContent(json,
                                                Encoding.UTF8,
                                                "application/json");

            // Note: These next lines are commented out to prevent an
            //       actual HTTP call, since this is just a prototype.

            //_client.SendAsync(request)
            //      .ContinueWith(responseTask =>
            //      {
            //          Console.WriteLine("Response: {0}", responseTask.Result);
            //      });
        }
    }
}
