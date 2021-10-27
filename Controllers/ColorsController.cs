using System;
using System.Collections.Generic;
using DockerComposeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerComposeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorsController : ControllerBase
    {
        private readonly ColorContext _context;
        private readonly ILogger<ColorsController> _logger;

        public ColorsController(
            ColorContext context,
            ILogger<ColorsController> logger
        )
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Color>> GetColorItems()
        {
            _logger.LogInformation("Color Items requested at: {time}", DateTimeOffset.UtcNow);
            return _context.ColorItems;
        }
    }
}
