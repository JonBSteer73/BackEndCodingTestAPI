using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BackEndCodingAssignmentAPI.Controllers
{
    [ApiController]
    [Route("Test")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Array")]
        public ActionResult GetArray()
        {
            var rng = new Random();
            var numberList = new List<int>();
            for (var i = 0;i<20;i++)
            {
                numberList.Add(rng.Next(0, 1000));
            }
            return Ok(numberList);
        }

        [HttpGet("Guid")]
        public ActionResult GetGuid()
        {
            return Ok(Guid.NewGuid().ToString());
        }

        [HttpGet("Object")]
        public ActionResult GetObject()
        {
            return Ok(new
            {
                Property1 = new Random().Next(),
                Property2 = Guid.NewGuid().ToString(),
                Property3 = DateTimeOffset.UtcNow
            });
        }
    }
}
