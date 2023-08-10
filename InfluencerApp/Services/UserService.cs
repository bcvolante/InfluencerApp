using InfluencerApp.Model.Master;
using InfluencerApp.Model.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    public class UserService : IUserService
    {
        public async Task<UserModel> GetByEmail(string email)
        {
            var returnResponse = new UserModel();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetByEmail}{email}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<UserModel>(deserializeResponse.Content.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<string> UpdateUsers(UpdateUserRequest _UpdateUserRequest)
        {
            string returnStr = string.Empty;
            using (var client = new HttpClient())
            {
                var url = $"{APIs._baseUrl}{APIs.UpdateUsers}";

                var serializedStr = JsonConvert.SerializeObject(_UpdateUserRequest);

                var response = await client.PutAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    returnStr = await response.Content.ReadAsStringAsync();
                }
            }
            return returnStr;
        }
        public async Task<UserViewResponse> GetById(string id)
        {
            var returnResponse = new UserViewResponse();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<UserViewResponse>(deserializeResponse.Content.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }



        
    }
}
