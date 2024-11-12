﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRegisterApplication.Data;

#nullable disable

namespace StudentRegisterApplication.Migrations.User
{
    [DbContext(typeof(UserContext))]
    [Migration("20241112081101_user")]
    partial class user
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentRegisterApplication.Model.SystemUser", b =>
                {
                    b.Property<int>("SystemUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SystemUserId"));

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("bit");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("SystemUserId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("SystemUsers");
                });

            modelBuilder.Entity("StudentRegisterApplication.Model.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemUserId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("SystemUserId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentRegisterApplication.Model.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"));

                    b.Property<bool>("AddRemove")
                        .HasColumnType("bit");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SetGrade")
                        .HasColumnType("bit");

                    b.HasKey("UserRoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("StudentRegisterApplication.Model.SystemUser", b =>
                {
                    b.HasOne("StudentRegisterApplication.Model.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("StudentRegisterApplication.Model.Teacher", b =>
                {
                    b.HasOne("StudentRegisterApplication.Model.SystemUser", "SystemUser")
                        .WithMany()
                        .HasForeignKey("SystemUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SystemUser");
                });
#pragma warning restore 612, 618
        }
    }
}