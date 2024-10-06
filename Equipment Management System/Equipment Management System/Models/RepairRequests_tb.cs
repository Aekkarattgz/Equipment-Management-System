using Equipment_Management_System.Migrations;

namespace Equipment_Management_System.Models
{
    public class RepairRequests_tb
    {
        public int RepairRequestId { get; set; } // Primary Key
        public int EquipmentId { get; set; } // Foreign Key ที่เชื่อมกับ Equipment
        public int UserId { get; set; } // Foreign Key ที่เชื่อมกับ User
        public DateTime RequestDate { get; set; } // วันที่ขอซ่อม
        public string Description { get; set; } // รายละเอียดปัญหาที่เกิดขึ้น
        public string Status { get; set; } // สถานะ เช่น "Pending", "In Repair", "Completed"

        // Navigation Properties
        public Equipment_tb Equipment { get; set; } // การเชื่อมโยงกับ Equipment
        public User_tb User { get; set; } // การเชื่อมโยงกับ User

    }
}
