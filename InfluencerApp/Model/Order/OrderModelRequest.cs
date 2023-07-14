using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Order
{
    public class OrderModelRequest
    {
        public Guid UserId { get; set; }
        public Guid? InfluencerId { get; set; }
        public string Date { get; set; }
        public Guid? TimeId { get; set; }
    }
}
