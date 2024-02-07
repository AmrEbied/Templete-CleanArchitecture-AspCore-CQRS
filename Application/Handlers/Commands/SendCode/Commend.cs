using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.SendCode
{
    public class Commend : IRequest<AuthModel>
    {
        public string Email { get; set; } = null!;
    }
}
