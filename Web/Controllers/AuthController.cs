using Application.Handlers.Commands.ChangePassword.Dto;
using Application.Handlers.Commands.ForgetPassword.Dto;
using Application.Handlers.Commands.Login.Dto;
using Application.Handlers.Commands.RefreshToken.Dto;
using Application.Handlers.Commands.Register.Dto;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Web.PathUrl;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
         
        [HttpPost(ApiRoutes.Identity.Register)]
        [ProducesResponseType(typeof(RegisterResponseDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> Register([FromForm] RegisterDto model)
        {

            return Ok(await _mediator.Send(new Application.Handlers.Commands.Register.Commend { Model = model }));

        } 
        [HttpPost(ApiRoutes.Identity.Login)]
        [ProducesResponseType(typeof(LoginResponseDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> Login([FromForm] LoginDto model)
        {

            return Ok(await _mediator.Send(new Application.Handlers.Commands.Login.Commend { Model = model }));

        } 
        [HttpPost(ApiRoutes.Identity.ForgetPassword)]
        [ProducesResponseType(typeof(AuthModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> ForgetPassword([FromForm] ForgetPasswordDto model)
        {
            return Ok(await _mediator.Send(new Application.Handlers.Commands.ForgetPassword.Commend { Model = model }));

        } 
        [HttpPost(ApiRoutes.Identity.ChangePassword)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        [ProducesResponseType(typeof(AuthModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ChangePassword([FromForm] ChangePasswordDto model)
        {
            return Ok(await _mediator.Send(new Application.Handlers.Commands.ChangePassword.Commend { Model = model }));

        }
        [HttpPost(ApiRoutes.Identity.SendCode)]
        [ProducesResponseType(typeof(AuthModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> SendCode(string email)
        {
            return Ok(await _mediator.Send(new Application.Handlers.Commands.SendCode.Commend { Email = email }));

        }
        [Authorize] 
        [HttpPost(ApiRoutes.Identity.RefreshToken)]
        [ProducesResponseType(typeof(RefreshTokenResponseDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            return Ok(await _mediator.Send(new Application.Handlers.Commands.RefreshToken.Commend { Token = refreshToken }));

        }
        [Authorize] 
        [HttpPost(ApiRoutes.Identity.RevokeToken)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> RevokeToken(string refreshToken)
        {
            return Ok(await _mediator.Send(new Application.Handlers.Commands.RevokeToken.Commend { Token = refreshToken }));

        }
    }
}
