using Application.Handlers.Commands.Register.Dto;
using Application.Mappings;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.Register
{
    public class Commend : IRequest<RegisterResponseDTO>, IMapFrom<RegisterModel>
    {
        public RegisterDto? Model { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RegisterDto, RegisterModel>().ReverseMap()
                 .IgnoreAllNonExisting();
            profile.CreateMap<AuthModel, RegisterResponseDTO>().ReverseMap()
                 .IgnoreAllNonExisting();
        }
    }
}
