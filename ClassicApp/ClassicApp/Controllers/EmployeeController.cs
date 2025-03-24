using ClassicApp.ExteriorModels;
using ClassicApp.Performers;
using Microsoft.AspNetCore.Mvc;

namespace ClassicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public async Task<JsonResult> GetEmployee([FromBody] GetEmployeeRequest request, [FromHeader] string traceId, [FromQuery] bool isPreLoad = false)
        {
            try
            {
                var results = await Task.Run(() => new EmployeePerformer() { }.DoAction(HttpContext, traceId, request));
                return new JsonResult(results);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
