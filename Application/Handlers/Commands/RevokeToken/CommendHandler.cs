using Domain.Abstractions;
using MediatR;

namespace Application.Handlers.Commands.RevokeToken
{
    public class CommendHandler : IRequestHandler<Commend, bool>
    {
        private readonly IAuthService _authService; 
        public CommendHandler(IAuthService authService )
        {
            _authService = authService; 
        }
        public async Task<bool> Handle(Commend request, CancellationToken cancellationToken)
        {

          return  await _authService.RevokeTokenAsync(request.Token);


        } 
    }
}
