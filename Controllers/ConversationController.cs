using Microsoft.AspNetCore.Mvc;
using projectApi.DTO;
using projectApi.Model;
using projectApi.Model.Conversation;
using projectApi.Model.Enums;
using projectApi.Service;

namespace projectApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ConversationController : ControllerBase
{
    private readonly ILogger<MatchController> _logger;
    private readonly IMatchService service;

    public ConversationController(ILogger<MatchController> logger, IMatchService service)
    {
        _logger = logger;
        this.service = service;
    }

    [HttpGet("[action]/{id}}")]
    public async Task<ActionResult<IEnumerable<Conversation>>> GetConverationsByUserId(int id)
    {
        var result = await service.GetConversationsByUserId(id);

        if(result == null)
        {
            return BadRequest("No conversation for this user.");
        }

        return Ok(result);
    }

     [HttpGet(Name = "GetUsers")]
    public async Task<IEnumerable<UserDto>> Get()
    {
        return await service.GetUsersAsync();
    }
}
