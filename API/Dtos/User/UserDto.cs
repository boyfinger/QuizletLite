namespace API.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Email { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string? RoleName { get; set; }
    }
}
