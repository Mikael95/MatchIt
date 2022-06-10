using Microsoft.AspNetCore.Mvc;
using projectApi.DTO;
using projectApi.Model;
using projectApi.Model.Enums;
using projectApi.Service;

namespace projectApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<MatchController> _logger;
    private readonly IMatchService service;

    public MatchController(ILogger<MatchController> logger, IMatchService service)
    {
        _logger = logger;
        this.service = service;
    }

    [HttpPost("[action]/{nickName}/{description}/{email}/{gender}/{interestedIn}")]
    public async Task<ActionResult> Post(string nickName, string description, string email, Enums.Genders gender, Enums.Genders interestedIn)
    {
        var user = new UserDto()
        {
            NickName = nickName,
            Description = description,
            Email = email,
            Popularity = 2,
            Gender = gender,
            InterestedIn = interestedIn
        };
        
        await service.PostUserAsync(user);
        return Ok();
    }

     [HttpGet(Name = "GetUsers")]
    public async Task<IEnumerable<UserDto>> Get()
    {
        return await service.GetUsersAsync();
    }
}
