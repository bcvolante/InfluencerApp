using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Influencer
{
    public class ServiceViewModel
    {
        public Guid Id { get; set; }
        public Guid InfluencerId { get; set; }
        public Guid? TypeId { get; set; }
        public string Type { get; set; }
        public Guid? ServiceSettingId { get; set; }
        public string ServiceSetting { get; set; }
        public double Amount { get; set; }
    }
}
