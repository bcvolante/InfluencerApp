using InfluencerAPI.Models.OrdersDTO;
using InfluencerApp.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    internal interface IOrderService
    {
        public Task<string> CreateOrder(OrderModelRequest _OrderModelRequest);
        public Task<string> CreateDetail(List<DetailModel> _DetailModel);
        public Task<string> CreateTarget(List<TargetViewModel> _TargetViewModel);

		public Task<List<OrderUserResponse>> GetUserById(string id);
        public Task<List<OrderResponse>> GetOrderById(string id);
        public Task<List<Product>> CheckoutOrderById(string id);
        public Task<List<TargetViewModel>> ViewOrderTarget(string id);
        public Task<List<DetailModel>> ViewOrderDetail(string id);
        public Task<OrderModelRequest> ViewOrder(string id);



    }
}
