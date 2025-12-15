using Microsoft.EntityFrameworkCore;
using RDControl.Domain.Entities;
using RDControl.Repository.Mapping;

namespace RDControl.Repository.Context
{
    public class RDControlContext : DbContext
    {
        public RDControlContext(DbContextOptions<RDControlContext> op=null) : base(op)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=RDControl;user=root;password=");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Place> Places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Client>(new ClientMap().Configure);
            modelBuilder.Entity<Equipment>(new EquipmentMap().Configure);
            modelBuilder.Entity<Technician>(new TechnicianMap().Configure);
            modelBuilder.Entity<Place>(new PlaceMap().Configure);
            modelBuilder.Entity<Report>(new ReportMap().Configure);
        }
    }
}
