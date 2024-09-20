
namespace HelloWorldApi.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Web.Http;
    using HelloWorldApi.Model;
    using Newtonsoft.Json;

    public class HelloWorldController : ApiController
    {
        private IConfigService configSvc;

        public HelloWorldController(IConfigService configSvc)
        {
            this.configSvc = configSvc;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    JsonConvert.SerializeObject(new
                    {
                        Host = Dns.GetHostName(),
                        Env = this.configSvc.Evn,
                        DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")
                    }),
                    Encoding.UTF8,
                    "application/json")
            };
        }
    }
}
