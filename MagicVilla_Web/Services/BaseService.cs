using MagicVilla_Web.Models.Model;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClientFactory { get; set; }
        public BaseService()
        {
            this.responseModel = new();
            this.httpClientFactory = httpClientFactory;
        }

        public Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            throw new NotImplementedException();
        }
        //public Task<T> SendAsync<T>(APIRequest apiRequest)
        //{
        //    try
        //    {
        //        var client = HttpClient.CreateClient("MagicAPI");
        //        HttpRequestMessage message = new HttpRequestMessage();
        //        message.Headers.Add("Accept", "application/json");
        //        message.RequestUri = new Uri(apiRequest.Url);
        //        if (apiRequest.Data != null)
        //        {
        //            message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
        //                Encoding.UTF8, "application/json");

        //        }
        //    }

        //}
    }
}
