using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Influencer
{
    public class RestDayModel
    {
        public Guid Id { get; set; }
        public Guid InfluencerId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Guid TimeId { get; set; }
    }
}
