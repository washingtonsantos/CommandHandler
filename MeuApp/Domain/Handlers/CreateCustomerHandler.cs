using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MeuApp.Domain.Commands.Requests;
using MeuApp.Domain.Commands.Responses;

namespace MeuApp.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                 Id = Guid.NewGuid(),
                 Name = "Washington Santos",
                 Email = "washington@email.com",
                 Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}