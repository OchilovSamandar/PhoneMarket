namespace PhoneMarket.Model
{
    public class User
    {
        public int Id { get; set; }
        
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public Role? Role { get; set; }
        public List<Phone>? Phones { get; set; }
    }
}
