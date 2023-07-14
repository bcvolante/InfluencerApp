using InfluencerApp.Model.Influencer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    internal interface IInfluencerService
    {
        public Task<List<InfluencerViewModel>> GetInfluencerByRanking();
        public Task<InfluencerViewModel> GetInfluencerById(string id);
        public Task<List<ServiceViewModel>> GetInfluencerServiceById(string id);
        public Task<List<RestDayModel>> GetInfluencerRestDayById(string id);
		public Task<List<TimeViewModel>> GetInfluencerTimeTypeById(string id);
        public Task<List<InfluencerViewModel>> GetInfluencerByFilter(string genderId, string industryId, string nationalityId, string name);
    }
}
