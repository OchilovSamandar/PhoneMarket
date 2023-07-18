namespace PhoneMarket.Dto
{
    public class PhoneDto
    {
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool isNew { get; set; } = true;
    }
}
