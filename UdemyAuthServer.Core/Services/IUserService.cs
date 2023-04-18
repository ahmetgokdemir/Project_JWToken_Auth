﻿using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.DTOs;

namespace UdemyAuthServer.Core.Services
{
    // 16. IUserService interface'sinin oluşturulması

    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}