using Carwash.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carwash.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarModelController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CarModelController> _logger;

        public CarModelController(ILogger<CarModelController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CarModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CarModel
            {
                CreatedOn = DateTime.Now.AddDays(index),
                Name = rng.Next(-20, 55).ToString(),
                About = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
