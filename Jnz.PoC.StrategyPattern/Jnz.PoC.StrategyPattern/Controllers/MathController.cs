using Jnz.PoC.StrategyPattern.Strategies.Math;
using Microsoft.AspNetCore.Mvc;

namespace Jnz.PoC.StrategyPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathStrategy _mathStrategy;

        public MathController(IMathStrategy mathStrategy)
        {
            _mathStrategy = mathStrategy;
        }

        [HttpGet]
        public IActionResult Calculate(int a, int b, Operator op)
        {
            var result = _mathStrategy.Calculate(a, b, op);

            return Ok(result);
        }
    }
}
