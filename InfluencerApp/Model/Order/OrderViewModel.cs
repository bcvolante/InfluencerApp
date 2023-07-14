using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Order
{
    public class OrderViewModel
    {
        public Guid UserId { get; set; }
        public Guid? InfluencerId { get; set; }
    }
}
