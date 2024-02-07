using Domain.Abstractions;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.SendCode
{
    public class CommendHandler : IRequestHandler<Commend, AuthModel>
    {
        private readonly IAuthService _authService; 
        public CommendHandler(IAuthService authService)
        {
            _authService = authService; 
        }
        public async Task<AuthModel> Handle(Commend request, CancellationToken cancellationToken)
        {

            return await _authService.SendCodeAsync(request.Email);


        }
    }
}
