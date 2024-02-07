using Application.Handlers.Commands.ChangePassword.Dto;
using Application.Mappings;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.ChangePassword
{
    public class Commend : IRequest<AuthModel>, IMapFrom<ChangePasswordDto>
    {
        public ChangePasswordDto? Model { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ChangePasswordDto, ChangePasswordModel>().ReverseMap()
                 .IgnoreAllNonExisting();
        }
    }
}
