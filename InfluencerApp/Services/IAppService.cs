using InfluencerApp.Model.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Services
{
    internal interface IAppService
    {
        public Task<string> Create(SettingsModel _SettingsModel);
        public Task<List<SettingsResponseModel>> FilterBy(string typeId);
        public Task<List<SettingsResponseModel>> GetIndustryWithData(string industryTypeId);
        public Task<List<SettingsResponseModel>> GetAll();
    }
}
