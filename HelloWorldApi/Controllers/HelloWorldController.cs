using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace HelloWorldApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    JsonConvert.SerializeObject(new
                    {
                        Host = Dns.GetHostName(),
                        DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")
                    }),
                    Encoding.UTF8,
                    "text/html")
            };
        }
    }
}
