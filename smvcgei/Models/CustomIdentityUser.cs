using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace smvcgei.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        [PersonalData]
        [Display(Name ="Nombre")]
        public string Nombrecompleto { get; set; }
    }
}
