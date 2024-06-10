using Kolos2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController: ControllerBase
{
    private readonly IClientSubscriptionService _subscriptionService;

    public ClientController(IClientSubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpGet("{idClient}")]
    public async Task<IActionResult> GetClientSubInfo(int idClient)
    {
        var responseInfo = await _subscriptionService.GetInfoClientSub(idClient);
        if (responseInfo == null)
        {
            return NoContent();
        }

        return Ok(responseInfo);
    }


}