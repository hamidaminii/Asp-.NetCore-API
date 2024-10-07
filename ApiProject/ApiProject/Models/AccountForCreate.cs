namespace ApiProject.Models
{
    public class AccountForCreate
    {
        public string? Name { get; set; } = string.Empty;
        public string? Family { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
    }
}
