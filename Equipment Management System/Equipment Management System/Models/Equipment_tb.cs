namespace Equipment_Management_System.Models
{
    public class Equipment_tb
    {
        public int EquipmentId { get; set; } // Primary Key
        public string Name { get; set; } // ชื่ออุปกรณ์
        public string Status { get; set; } // สถานะ เช่น "Available", "In Use", "Under Repair"

    }
}
