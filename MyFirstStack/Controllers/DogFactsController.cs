using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstStack.Infrastructure;

namespace MyFirstStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogFactsController : ControllerBase
    {
        private readonly DogFactService _facts;

        public DogFactsController(DogFactService facts)
        {
            _facts = facts;
        }

        [HttpGet]
        public async Task<ActionResult<string[]>> GetFacts()
        {
            var dogFacts = await _facts.GetFact(10);

            if (dogFacts == null)
            {
                return NotFound();
            }

            return Ok(dogFacts.Facts);
        }

    }
}
