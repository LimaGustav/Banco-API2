using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExoApi.Repositories;

namespace ExoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : ControllerBase
    {
        public MedicosRepository repository = new MedicosRepository();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.Listar());
        }
    }
}