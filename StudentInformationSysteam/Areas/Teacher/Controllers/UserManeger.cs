using StudentIformationSysteam.Core.Models;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    public class UserManeger<T>
    {
        internal Task<AppUser> GetUserAsync(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}