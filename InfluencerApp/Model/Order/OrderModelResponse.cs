using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Order
{
    public class OrderModelResponse
    {
        public Guid UserId { get; set; }
        public Guid? InfluencerId { get; set; }
        public string Date { get; set; }
        public Guid? TimeId { get; set; }
        public static List<DetailModel> _DetailModel { get; set; }
        public static List<TargetViewModel> _TargetViewModel { get; set; }


    }
}
