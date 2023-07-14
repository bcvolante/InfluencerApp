using InfluencerApp.Model.Login;
using InfluencerApp.Model.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    internal interface ILoginService
    {
        public Task<string> Create(RegisterModel _RegisterModel);
        public Task<string> CreateLogin(LoginModel _LoginModel);
        public Task<MainResponseModel> AuthenticateUser(LoginModel _LoginModel);
    }
}
