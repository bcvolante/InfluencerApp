using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Order
{
    public class DetailModel
    {
        public Guid Id { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? ServiceTypeId { get; set; }
        public double Amount { get; set; }
    }
}
