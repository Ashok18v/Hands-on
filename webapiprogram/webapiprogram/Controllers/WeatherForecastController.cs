using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace webapiprogram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private List<Employee> employee;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            employee = new List<Employee>();
            employee.Add(new Employee { Id = 10, Name = "Ashok",Address="Vijyawada" });
            employee.Add(new Employee { Id=11,Name="Veera",Address="Microsoft"});   
            return Ok(employee);
        }
        [HttpPut]
        public ActionResult Putbyid(int i)
        {
            var emploee = employee.Where(x => x.Id == i).First();
            emploee.Name = "Sai";
            emploee.Address = "Banglore";
            employee.Add(emploee);
            return Ok(employee);
            
        }

      //  public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}