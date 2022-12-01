using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RecipesApp.Application.DTOs;
using RecipesApp.Application.DTOs.CustomResponseDTOs;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.Interfaces.IService;
using RecipesApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ResponseDto<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new AppUser { Email = createUserDto.Email, UserName = createUserDto.UserName };
            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return ResponseDto<AppUserDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return ResponseDto<AppUserDto>.Success(_mapper.Map<AppUserDto>(user), 200);
        }

        public async Task<ResponseDto<AppUserDto>> GetUserNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return ResponseDto<AppUserDto>.Fail("UserName not found", 404, true);
            }
            return ResponseDto<AppUserDto>.Success(_mapper.Map<AppUserDto>(user), 200);
        }
    }
}
