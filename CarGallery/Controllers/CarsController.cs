using Application;
using Application.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarsController:ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carservice)
        {
            _carService = carservice;
        }
        [HttpPost]
        public async Task<IActionResult> AddCarAsync(AddCarCommand command)
        {
            _carService.Add(command);

            return Ok();
        }
    }
}
