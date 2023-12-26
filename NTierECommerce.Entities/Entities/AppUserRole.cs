using Microsoft.AspNetCore.Identity;

namespace NTierECommerce.Entities.Entities
{
    public class AppUserRole:IdentityRole<int>
    {
        public string? Description { get; set; }
       
    }
}
