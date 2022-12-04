using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.DTOs.TokenDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IService
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<TokenDto>> CreateToken(LoginDto loginDto);
        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<ResponseDto<NoContentDto>> RevokeRefreshToken(string refreshToken);

    }
}
