using RecipesApp.Application.DTOs.TokenDtos;
using RecipesApp.Domain.Entities;
using RecipesApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IService
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);
    }
}
