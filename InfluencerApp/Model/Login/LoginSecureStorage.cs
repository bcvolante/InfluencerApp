using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Login
{
    public class LoginSecureStorage
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool EmailVerified { get; set; }
        public bool PasswordVerified { get; set; }
        public bool IsActive { get; set; }
        public string? RefreshToken { get; set; }
        public Guid? TypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string ImagePath { get; set; }
        public Guid? IndustryId { get; set; }
        public int Size { get; set; }
        public Guid? InfluencerId { get; set; }
        public Guid? UserTypeId { get; set; }
        public string AccessToken { get; set; }
    }
}
