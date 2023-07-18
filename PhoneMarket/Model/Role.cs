using Microsoft.EntityFrameworkCore;
using PhoneMarket.Dto.enums;
using System.ComponentModel.DataAnnotations;

namespace PhoneMarket.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
       
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Permission> Permissions { get; set; }
        
    }
}
