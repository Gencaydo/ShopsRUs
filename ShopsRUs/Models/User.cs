namespace ShopsRUs.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public UserType? Type { get; set; } = null;
    }
    public enum UserType
    {
        Employee =1,
        Affiliate =2,
        Customer =3,
    }
}
