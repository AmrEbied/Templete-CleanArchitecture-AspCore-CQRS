using Application.Handlers.Commands.Register.Dto;
using AutoMapper;
using Domain.Abstractions;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.Register
{
    public class CommendHandler : IRequestHandler<Commend, RegisterResponseDTO>
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper ;
        public CommendHandler(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }
        public async Task<RegisterResponseDTO> Handle(Commend request, CancellationToken cancellationToken)
        { 

          return  _mapper.Map<RegisterResponseDTO>(await _authService.RegisterAsync(_mapper.Map<RegisterModel>(request.Model)));


        }
    }
}
