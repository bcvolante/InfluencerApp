using InfluencerAPI.Models.OrdersDTO;
using InfluencerApp.Model.Master;
using InfluencerApp.Model.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    public class OrderService: IOrderService
    {
        public async Task<string> CreateOrder(OrderModelRequest _OrderModelRequest)
        {
            string returnStr = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.CreateOrder}";

                    var serializedStr = JsonConvert.SerializeObject(_OrderModelRequest);

                    var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        returnStr = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                returnStr = ex.Message;
            }
            return returnStr;
        }
        public async Task<string> CreateDetail(List<DetailModel> _DetailModel)
        {
            string returnStr = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.CreateDetail}";

                    var serializedStr = JsonConvert.SerializeObject(_DetailModel);

                    var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        returnStr = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                returnStr = ex.Message;
            }
            return returnStr;
        }
        public async Task<string> CreateTarget(List<TargetViewModel> _TargetViewModel)
        {
            string returnStr = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.CreateTarget}";

                    var serializedStr = JsonConvert.SerializeObject(_TargetViewModel);

                    var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        returnStr = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                returnStr = ex.Message;
            }
            return returnStr;
        }

		public async Task<List<OrderUserResponse>> GetUserById(string id)
		{
			var returnResponse = new List<OrderUserResponse>();
			try
			{
				using (var client = new HttpClient())
				{
					var url = $"{APIs._baseUrl}{APIs.GetUserById}{id}";
					var apiResponse = await client.GetAsync(url);

					if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var response = await apiResponse.Content.ReadAsStringAsync();
						var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
						if (deserializeResponse.IsSuccess)
						{
							returnResponse = JsonConvert.DeserializeObject<List<OrderUserResponse>>(deserializeResponse.Content.ToString());
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
        public async Task<List<OrderResponse>> GetOrderById(string id)
        {
            var returnResponse = new List<OrderResponse>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.GetOrderById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<OrderResponse>>(deserializeResponse.Content.ToString());
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
        public async Task<List<Product>> CheckoutOrderById(string id)
        {
            var returnResponse = new List<Product>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.CheckoutOrderById}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<Product>>(deserializeResponse.Content.ToString());
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
        public async Task<List<TargetViewModel>> ViewOrderTarget(string id)
        {
            var returnResponse = new List<TargetViewModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.ViewOrderTarget}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<TargetViewModel>>(deserializeResponse.Content.ToString());
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
        public async Task<List<DetailModel>> ViewOrderDetail(string id)
        {
            var returnResponse = new List<DetailModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.ViewOrderDetail}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<DetailModel>>(deserializeResponse.Content.ToString());
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
        public async Task<OrderModelRequest> ViewOrder(string id)
        {
            var returnResponse = new OrderModelRequest();
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{APIs._baseUrl}{APIs.ViewOrder}{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<OrderModelRequest>(deserializeResponse.Content.ToString());
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
