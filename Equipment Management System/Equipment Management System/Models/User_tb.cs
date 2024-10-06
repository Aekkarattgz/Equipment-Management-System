namespace Equipment_Management_System.Models
{
    public class User_tb
    {
        public int UserId { get; set; } // Primary Key
        public string Username { get; set; } // ชื่อผู้ใช้
        public string Password { get; set; } // รหัสผ่าน
    }
}
