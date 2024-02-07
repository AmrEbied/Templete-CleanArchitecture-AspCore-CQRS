using AutoMapper;
using Domain.Abstractions;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.ChangePassword
{
    public class CommendHandler : IRequestHandler<Commend, AuthModel>
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;
        public CommendHandler(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }
        public async Task<AuthModel> Handle(Commend request, CancellationToken cancellationToken)
        {

            return await _authService.ChangePasswordAsync((_mapper.Map<ChangePasswordModel>(request.Model)));


        }
    }
}
