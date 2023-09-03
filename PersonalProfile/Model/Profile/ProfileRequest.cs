using System.ComponentModel.DataAnnotations;

namespace PersonalProfile.Model.Profile
{
    public class ProfileRequest
    {
        [StringLength(2)]
        public string IdType { get; set; }
        [StringLength(100)]
        public string IdNo { get; set; }
    }
}
