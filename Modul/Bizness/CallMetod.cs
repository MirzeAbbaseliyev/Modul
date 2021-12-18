using Modul.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Modul.Bizness
{
    public class CallMetod
    {
        public async Task<Response> CallPost(dynamic body, string url)
        {
            //var cert = new X509Certificate2(Path.Combine(_environment.ContentRootPath, "sts_dev_cert.pfx"), "1234");
            //var handler = new HttpClientHandler();
            //handler.ClientCertificates.Add(cert);

            //using (var httpClient = new HttpClient(handler))

            try
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        //status coda uygun error qaytarmaq
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        dynamic d = JsonConvert.DeserializeObject<ExpandoObject>(apiResponse, new ExpandoObjectConverter());
                        return new Response { Object = d, Result = new Result { Success = new Success() } };
                    }
                }
            }
            catch (Exception e)
            {
                return new Response { Result = new Result { Error = new Error { Exists = true, Message = e.Message } } };
            }




        }
    }
}
