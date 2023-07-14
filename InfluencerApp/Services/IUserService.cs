using InfluencerApp.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    internal interface IUserService
    {
        public Task<UserModel> GetByEmail(string email);
        public Task<string> UpdateUsers(UpdateUserRequest _UpdateUserRequest);
    }
}
