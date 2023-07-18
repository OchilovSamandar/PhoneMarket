namespace PhoneMarket.Dto
{
    public class PermissionDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
            
        public PermissionDto(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public PermissionDto()
        {
        }
    }
}
