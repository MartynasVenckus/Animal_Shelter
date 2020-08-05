using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Šitie.Models;

namespace Šitie.Controllers
{
    [ApiController]
    [Route("/animals")]
    public class AnimalController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public AnimalController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return dbContext.Animals;
        }
    }
}
