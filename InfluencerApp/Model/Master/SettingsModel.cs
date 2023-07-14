using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerApp.Model.Master
{
    public class SettingsModel
    {
        [Required(ErrorMessage = "This is required.")]
        public Guid TypeId { get; set; }
        [Required(ErrorMessage = "This is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This is required.")]
        public string ImagePath { get; set; }

        //[Required(ErrorMessage = "This is required.")]
        //public string firstName { get; set; }
        //public string lastName { get; set; }
        //[Required(ErrorMessage = "This is required.")]
        //public string emailAddress { get; set; }
        //[Required(ErrorMessage = "This is required."), MinLengthAttribute(8, ErrorMessage = "Must be atleast 8 characters long.")]
        //public string password { get; set; }
        //[Required(ErrorMessage = "This is required.")]
        //public string mobileNumber { get; set; }
    }
}
