// สร้างตัวแทนฐานข้อมูล
using Equipment_Management_System.Migrations;
using Equipment_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Equipment_Management_System.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Equipment_tb> Equipments { get; set; }
        
        public DbSet<User_tb> Users { get; set; }
       

        public DbSet<RepairRequests_tb> RepairRequests { get; set; }

        // กำหนด Primary Key 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // กำหนด Primary Key สำหรับ Equipment_tb
            modelBuilder.Entity<Equipment_tb>()
                .HasKey(e => e.EquipmentId);

            // กำหนด Primary Key สำหรับ User_tb
            modelBuilder.Entity<User_tb>()
                .HasKey(u => u.UserId);

            // กำหนด Primary Key สำหรับ RepairRequests_tb
            modelBuilder.Entity<RepairRequests_tb>()
                .HasKey(r => r.RepairRequestId);
        }


    }
}

