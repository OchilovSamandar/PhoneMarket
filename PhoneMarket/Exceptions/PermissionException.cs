namespace PhoneMarket.Exceptions
{
    public class PermissionException :Exception
    {
        public PermissionException() { 
        
        }

        public PermissionException(string? message) : base(message)
        {
        }

       

        public override string ToString()
        {
            return $"PermissionExseption: Message={"Bunday Permission mavjud emas"}";
        }
    }
}
