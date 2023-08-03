using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Configuration
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
