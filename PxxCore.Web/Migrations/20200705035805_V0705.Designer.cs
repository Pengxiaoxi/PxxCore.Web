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
    [Migration("20200705035805_V0705")]
    partial class V0705
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PxxCore.Entity.Base_Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("Base_Department");
                });

            modelBuilder.Entity("PxxCore.Entity.Base_SysLog", b =>
                {
                    b.Property<string>("SysLogId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(32);

                    b.Property<string>("CreateUserId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("CreateUserName")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddressName")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("LogType")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("ObjectId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("SysLogId");

                    b.ToTable("Base_SysLog");
                });

            modelBuilder.Entity("PxxCore.Entity.Base_User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("Base_User");
                });
#pragma warning restore 612, 618
        }
    }
}