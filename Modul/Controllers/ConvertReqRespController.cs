using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modul.Bizness;
using Modul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public async Task<Response> Test([FromBody] Request jsonData)
        {

            var call = new CallMetod();

            var result = await call.CallPost(jsonData.Body, "https://localhost:6001/ConvertReqResp/GetClinet");


            //switch (jsonData.MetodType)
            //{
            //    case "Post": result= await call.CallPost(jsonData.Body, jsonData.Url,jsonData.Certificate); break;
            //    case "Get": break;
            //    case "Put": break;
            //    default:
            //        break;
            //}

            return result;
        }

        [HttpPost]
        public Client GetClinet(Source source)
        {

            return new Client { Adress = new Adress { City = "Baki" }, Name = "Eli" };
        }



    }

    public class Source
    {
        public string Cif { get; set; }
    }

    public class Client
    {
        public string Name { get; set; } = "efs";
        public Adress Adress { get; set; } = new Adress();
    }

    public class Adress
    {
        public string City { get; set; } = "Awd";
    }
}
