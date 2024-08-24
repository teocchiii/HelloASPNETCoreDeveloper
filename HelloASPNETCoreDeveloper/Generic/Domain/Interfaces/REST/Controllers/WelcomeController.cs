using HelloASPNETCoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETCoreDeveloper.Generic.Domain.Interfaces.REST.Controllers;

[ApiController]
[Route(template:"[controller]")]
public class WelcomeController: ControllerBase
{

    [HttpGet]
    public string welcome()
    {
        return WelcomeBuilder.Build(null);
    }
}