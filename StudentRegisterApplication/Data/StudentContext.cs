using Microsoft.EntityFrameworkCore;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.Data
{
    internal class StudentContext : DbContext
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentRegisterDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProgrammingKnowledge> ProgrammingSkills { get; set; }

        public StudentContext()
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
