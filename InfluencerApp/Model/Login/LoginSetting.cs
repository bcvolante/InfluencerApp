using InfluencerApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Login
{
    public class LoginSetting
    {
        public static LoginSecureStorage LoginSecureStorage { get; set; }
        public const string BaseUrl = $"{APIs._baseUrl}";
    }
}
