using System.Threading.Tasks;
using MediatR;
using MeuApp.Domain.Commands.Requests;
using MeuApp.Domain.Commands.Responses;
using MeuApp.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace MeuApp.Controllers
{

    [ApiController]
    [Route("api/v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command)
        {

            var response = mediator.Send(command);

            return response;
        }
    }

}