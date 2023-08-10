using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Login
{
    public class LoginModelView
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public string? DateCreated { get; set; }
        public bool EmailVerified { get; set; }
        public bool PasswordVerified { get; set; }
        public string? RefreshToken { get; set; }
        public Guid InfluencerId { get; set; }
        public Guid UserTypeId { get; set; }
    }
}
