﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PxxCore.Repository.EFCore;

namespace PxxCore.Web.Migrations
{
    [DbContext(typeof(DbContextBase))]
    [Migration("20191114093522_v14")]
    partial class v14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PxxCore.Entity.Base_Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .HasMaxLength(32);

                    b.Property<int?>("Age");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("ModifyBy")
                        .HasMaxLength(32);

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sex")
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("Base_Department");
                });

            modelBuilder.Entity("PxxCore.Entity.Base_SysLog", b =>
                {
                    b.Property<string>("SysLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("CreateDate")
                        .HasMaxLength(32);

                    b.Property<string>("CreateUserId")
                        .HasMaxLength(32);

                    b.Property<string>("CreateUserName")
                        .HasMaxLength(32);

                    b.Property<string>("DepartmentId")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddress")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddressName")
                        .HasMaxLength(32);

                    b.Property<string>("LogType")
                        .HasMaxLength(2);

                    b.Property<string>("ModuleId")
                        .HasMaxLength(32);

                    b.Property<string>("ObjectId")
                        .HasMaxLength(32);

                    b.Property<string>("Remark")
                        .HasMaxLength(32);

                    b.Property<string>("Status")
                        .HasMaxLength(32);

                    b.HasKey("SysLogId");

                    b.ToTable("Base_SysLog");
                });

            modelBuilder.Entity("PxxCore.Entity.Base_User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .HasMaxLength(32);

                    b.Property<int?>("Age");

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("ModifyBy")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasMaxLength(32);

                    b.Property<string>("Sex")
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("Base_User");
                });
#pragma warning restore 612, 618
        }
    }
}
