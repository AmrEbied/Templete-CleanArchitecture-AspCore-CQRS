using Application.Handlers.Commands.ForgetPassword.Dto;
using Application.Mappings;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Handlers.Commands.ForgetPassword
{
    public class Commend : IRequest<AuthModel>, IMapFrom<ForgetPasswordDto>
    {
        public ForgetPasswordDto? Model { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ForgetPasswordDto, ForgetPasswordModel>().ReverseMap()
                 .IgnoreAllNonExisting(); 
        }
    }
}
