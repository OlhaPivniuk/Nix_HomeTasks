﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4.HW_3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp4.DbData.Client", b =>
            {
                b.Property<int>("ClientId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("ClientId")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("BirthDate")
                    .HasColumnType("datetime2")
                    .HasColumnName("BirthDate");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("LastName");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("Name");

                b.HasKey("ClientId");

                b.ToTable("Client");

                b.HasData(
                    new
                    {
                        ClientId = 1,
                        BirthDate = new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        LastName = "Pivniuk",
                        Name = "Olha"
                    },
                    new
                    {
                        ClientId = 2,
                        BirthDate = new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        LastName = "Pivniuk",
                        Name = "Iryna"
                    },
                    new
                    {
                        ClientId = 3,
                        BirthDate = new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        LastName = "Pivniuk",
                        Name = "Nataliaa"
                    },
                    new
                    {
                        ClientId = 4,
                        BirthDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        LastName = "Pivniuk",
                        Name = "Olena"
                    },
                    new
                    {
                        ClientId = 5,
                        BirthDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        LastName = "Pivniuk",
                        Name = "Dmytro"
                    });
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Employee", b =>
            {
                b.Property<int>("EmployeeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("EmployeeId")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DateOfBidth")
                    .HasColumnType("datetime2")
                    .HasColumnName("DateofBirth");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("FirstName");

                b.Property<DateTime>("HiredDate")
                    .HasColumnType("datetime2")
                    .HasColumnName("HiredDate");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("LastName");

                b.Property<int>("OfficeId")
                    .HasColumnType("int");

                b.Property<int>("TitleId")
                    .HasColumnType("int");

                b.HasKey("EmployeeId");

                b.HasIndex("OfficeId");

                b.HasIndex("TitleId");

                b.ToTable("Employee");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.EmployeeProject", b =>
            {
                b.Property<int>("EmployeeProjectId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("EmployeeId")
                    .HasColumnType("int");

                b.Property<int>("ProjectId")
                    .HasColumnType("int")
                    .HasColumnName("ProjectId");

                b.Property<decimal>("Rate")
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("Rate");

                b.Property<DateTime>("StartedDate")
                    .HasColumnType("datetime2")
                    .HasColumnName("StartedDate");

                b.HasKey("EmployeeProjectId");

                b.HasIndex("EmployeeId");

                b.HasIndex("ProjectId");

                b.ToTable("EmployeeProject");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Office", b =>
            {
                b.Property<int>("OfficeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("OfficeId")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Location")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)")
                    .HasColumnName("Location");

                b.Property<string>("Ttitle")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)")
                    .HasColumnName("Ttitle");

                b.HasKey("OfficeId");

                b.ToTable("Office");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Project", b =>
            {
                b.Property<int>("ProjectId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("ProjectId")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("Budget")
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("Budget");

                b.Property<int>("ClientId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("Name");

                b.Property<DateTime>("StartedDate")
                    .HasColumnType("datetime2")
                    .HasColumnName("StartedDate");

                b.HasKey("ProjectId");

                b.HasIndex("ClientId");

                b.ToTable("Project");

                b.HasData(
                    new
                    {
                        ProjectId = 1,
                        Budget = 1233222m,
                        ClientId = 1,
                        Name = "NewPark",
                        StartedDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        ProjectId = 2,
                        Budget = 1232132m,
                        ClientId = 2,
                        Name = "Champion",
                        StartedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        ProjectId = 3,
                        Budget = 2832382m,
                        ClientId = 3,
                        Name = "Star",
                        StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        ProjectId = 4,
                        Budget = 23841283m,
                        ClientId = 4,
                        Name = "Couple",
                        StartedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        ProjectId = 5,
                        Budget = 2381238m,
                        ClientId = 5,
                        Name = "Bukovel",
                        StartedDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                    });
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Title", b =>
            {
                b.Property<int>("TitleId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("TitleId")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)")
                    .HasColumnName("Name");

                b.HasKey("TitleId");

                b.ToTable("Title");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Employee", b =>
            {
                b.HasOne("ConsoleApp4.DbData.Office", "Office")
                    .WithMany("Employees")
                    .HasForeignKey("OfficeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("ConsoleApp4.DbData.Title", "Title")
                    .WithMany("Employees")
                    .HasForeignKey("TitleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Office");

                b.Navigation("Title");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.EmployeeProject", b =>
            {
                b.HasOne("ConsoleApp4.DbData.Employee", "Employee")
                    .WithMany("EmployeeProjects")
                    .HasForeignKey("EmployeeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("ConsoleApp4.DbData.Project", "Project")
                    .WithMany("EmployeeProjects")
                    .HasForeignKey("ProjectId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Employee");

                b.Navigation("Project");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Project", b =>
            {
                b.HasOne("ConsoleApp4.DbData.Client", "Client")
                    .WithMany("Projects")
                    .HasForeignKey("ClientId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Client");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Client", b =>
            {
                b.Navigation("Projects");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Employee", b =>
            {
                b.Navigation("EmployeeProjects");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Office", b =>
            {
                b.Navigation("Employees");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Project", b =>
            {
                b.Navigation("EmployeeProjects");
            });

            modelBuilder.Entity("ConsoleApp4.DbData.Title", b =>
            {
                b.Navigation("Employees");
            });
#pragma warning restore 612, 618
        }
    }
}
