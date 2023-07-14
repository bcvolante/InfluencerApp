using InfluencerApp.Model.Influencer;
using InfluencerApp.Model.Master;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    public class InfluencerService : IInfluencerService
    {
        public async Task<List<InfluencerViewModel>> GetInfluencerByRanking()
        {
            var returnResponse = new List<InfluencerViewModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetInfluencerByRanking}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<InfluencerViewModel>>(deserializeResponse.Content.ToString());
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

        public async Task<List<ServiceViewModel>> GetInfluencerServiceById(string id)
        {
            var returnResponse = new List<ServiceViewModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetInfluencerServiceById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<ServiceViewModel>>(deserializeResponse.Content.ToString());
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

        public async Task<List<RestDayModel>> GetInfluencerRestDayById(string id)
        {
            var returnResponse = new List<RestDayModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetInfluencerRestDayById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<RestDayModel>>(deserializeResponse.Content.ToString());
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

        public async Task<List<TimeViewModel>> GetInfluencerTimeTypeById(string id)
        {
            var returnResponse = new List<TimeViewModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetInfluencerTimeTypeById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<TimeViewModel>>(deserializeResponse.Content.ToString());
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

		public async Task<InfluencerViewModel> GetInfluencerById(string id)
		{
			var returnResponse = new InfluencerViewModel();
			try
			{
				using (var client = new HttpClient())
				{
					var url = $"{APIs._baseUrl}{APIs.GetInfluencerById}{id}";
					var apiResponse = await client.GetAsync(url);

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var response = await apiResponse.Content.ReadAsStringAsync();
						var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
						if (deserializeResponse.IsSuccess)
						{
							returnResponse = JsonConvert.DeserializeObject<InfluencerViewModel>(deserializeResponse.Content.ToString());
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

		public async Task<List<InfluencerViewModel>> GetInfluencerByFilter(string genderId, string industryId, string nationalityId, string name)
		{
			var returnResponse = new List<InfluencerViewModel>();
			try
			{
				using (var client = new HttpClient())
				{
					var url = $"{APIs._baseUrl}{APIs.GetInfluencerByFilter}{genderId}/{industryId}/{nationalityId}/{name}";
					var apiResponse = await client.GetAsync(url);

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var response = await apiResponse.Content.ReadAsStringAsync();
						var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
						if (deserializeResponse.IsSuccess)
						{
							returnResponse = JsonConvert.DeserializeObject<List<InfluencerViewModel>>(deserializeResponse.Content.ToString());
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
