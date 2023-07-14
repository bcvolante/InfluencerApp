using InfluencerApp.Model.Login;
using InfluencerApp.Model.Master;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    public class LoginService : ILoginService
    {
        public async Task<string> Create(RegisterModel _RegisterModel)
        {
            //var returnResponse = new List<RegisterResponseModel>();
            //LoginModel _LoginModel = new();
            string returnStr = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.CreateUsers}";

                    var serializedStr = JsonConvert.SerializeObject(_RegisterModel);

                    var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        returnStr = await response.Content.ReadAsStringAsync();
                        //var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(returnStr);
                        //if (deserializeResponse.IsSuccess)
                        //{
                        //    returnResponse = JsonConvert.DeserializeObject<List<RegisterResponseModel>>(deserializeResponse.Content.ToString());
                        //    _LoginModel.UserName = _RegisterModel.Email;
                        //    _LoginModel.Password = _RegisterModel.Password;
                        //    _LoginModel.UserId = returnResponse[0].Id;
                        //    await CreateLogin(_LoginModel);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                returnStr = ex.Message;
            }
            return returnStr;
        }
        public async Task<string> CreateLogin(LoginModel _LoginModel)
        {
            string returnStr = string.Empty;
            using (var client = new HttpClient())
            {
                var url = $"{APIs._baseUrl}{APIs.CreateUsersLogin}";

                var serializedStr = JsonConvert.SerializeObject(_LoginModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    returnStr = await response.Content.ReadAsStringAsync();
                }
            }
            return returnStr;
        }
        public async Task<MainResponseModel> AuthenticateUser(LoginModel _LoginModel)
        {
            var returnResponse = new MainResponseModel();
            //var returnResponse = new List<AuthenticateUserResponse>();
            //string returnStr = string.Empty;
            using (var client = new HttpClient())
            {
                var url = $"{APIs._baseUrl}{APIs.AuthenticateUsersLogin}";

                var serializedStr = JsonConvert.SerializeObject(_LoginModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    string returnStr = await response.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(returnStr);
                    //var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(returnStr);
                    //if (deserializeResponse.IsSuccess)
                    //{
                    //    returnResponse = JsonConvert.DeserializeObject<List<MainResponseModel>>(deserializeResponse.Content.ToString());
                    //}
                }
            }
            return returnResponse;
        }
    }
}
