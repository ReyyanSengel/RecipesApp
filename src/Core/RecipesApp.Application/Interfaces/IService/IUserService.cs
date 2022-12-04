using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.DTOs.TokenDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IService
{
    public interface IUserService
    {
        Task<ResponseDto<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<ResponseDto<AppUserDto>> GetUserNameAsync(string userName);
    }
}
