using Microsoft.AspNetCore.Mvc;
using HelloASPNETCoreDeveloper.Generic.Domain.Interfaces.REST.Resources;
namespace HelloASPNETCoreDeveloper.Generic.Domain.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class ByeController: ControllerBase
{
    [HttpGet("{name}")]
    public ByeResource Bye(string name)
    {
        return new ByeResource(name);
    }
}