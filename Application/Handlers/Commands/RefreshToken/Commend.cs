using Application.Handlers.Commands.RefreshToken.Dto;
using Application.Mappings;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.RefreshToken
{
    public class Commend : IRequest<RefreshTokenResponseDTO>, IMapFrom<TokenRequestModel>
    {
        public string Token { get; set; } = null!;

        public void Mapping(Profile profile)
        {
             
            profile.CreateMap<RefreshTokenResponseDTO, AuthModel>().ReverseMap()
                .IgnoreAllNonExisting();
        }
    }
}
