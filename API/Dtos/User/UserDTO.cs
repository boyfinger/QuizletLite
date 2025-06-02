namespace API.Dtos.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; } // Nếu cần tên vai trò thay vì ID
        public string Avatar { get; set; }

    }
}
