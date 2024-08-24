using HelloASPNETCoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETCoreDeveloper.Generic.Domain.Interfaces.REST.Controllers;

[ApiController]
[Route(template:"[controller]")]
public class WelcomeController: ControllerBase
{

    [HttpGet]
    public string Welcome()
    {
        return WelcomeBuilder.Build(null);
    }

    [HttpGet("{name}")]
    public string Welcome(String name)
    {
        return WelcomeBuilder.Build(name);
    }
}