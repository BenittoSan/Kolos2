using Kolos2.Context;
using Kolos2.Interfaces;
using Kolos2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kolos2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ClientPaymentController: ControllerBase
{
    private readonly Kolos2Context _dbContext;
    private readonly IClientRepository _clientRepository;
    private readonly ISubRepository _subRepository;
    

    public ClientPaymentController(Kolos2Context dbContext, IClientRepository clientRepository, ISubRepository subRepository)
    {
        _dbContext = dbContext;
        _clientRepository = clientRepository;
        _subRepository = subRepository;
    }
    



    [HttpGet("{idClient:int},{idSubscription:int}/Payment")]
    public async Task<IActionResult> GetPaymentInfo(int idClient, int idSubscription, Payment payment)
    {
        var client = await _clientRepository.GetClient(idClient);
        if (client ==  null)
        {
            return NotFound();
        }

        var sub = await _subRepository.GetSubscription(idSubscription);
        if (sub == null)
        {
            return NotFound();
        }

        return Ok("No malo brakowalo");


    }
}