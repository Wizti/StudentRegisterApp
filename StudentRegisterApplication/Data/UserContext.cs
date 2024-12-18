﻿using Microsoft.EntityFrameworkCore;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.Data
{
    internal class UserContext : DbContext
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentRegisterDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<UserRole> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
