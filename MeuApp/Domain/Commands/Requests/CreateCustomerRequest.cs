using System;
using MediatR;
using MeuApp.Domain.Commands.Responses;

namespace MeuApp.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}