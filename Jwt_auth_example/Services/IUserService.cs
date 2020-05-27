using Jwt_auth_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_auth_example.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModels model);
    }
}
