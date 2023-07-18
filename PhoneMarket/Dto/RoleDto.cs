using PhoneMarket.Dto.enums;
using PhoneMarket.Model;

namespace PhoneMarket.Dto
{
    public class RoleDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PermissionDto> PermissionDtos { get; set; }
    }
}
