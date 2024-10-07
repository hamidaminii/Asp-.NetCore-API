namespace ApiProject.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int? Phone { get; set; }
    }
}
