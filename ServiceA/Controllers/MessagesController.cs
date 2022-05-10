using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("messages")]
    public class MessagesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MessagesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            Console.WriteLine(_configuration["Name"]);
            Console.WriteLine(_configuration["Type"]);
            Console.WriteLine(_configuration["Value"]);
            Console.WriteLine(_configuration["IsActive"]);
            Console.WriteLine(_configuration["ApplicationName"]);
            return _configuration["Name"];
        }
    }
}