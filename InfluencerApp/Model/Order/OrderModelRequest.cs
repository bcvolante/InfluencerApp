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
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public string Status { get; set; }
        public string? Remarks { get; set; }
    }
}
