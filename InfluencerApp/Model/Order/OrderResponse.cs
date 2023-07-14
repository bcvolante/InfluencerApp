using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Order
{
	public class OrderResponse
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid InfluencerId { get; set; }
		public string Status { get; set; }
		public bool IsActive { get; set; }
		public bool IsApproved { get; set; }
		public string DateCreated { get; set; }
		public string Name { get; set; }
		public string ImagePath { get; set; }
		public Guid IndustryId { get; set; }
		public string Industry { get; set; }
	}
}
