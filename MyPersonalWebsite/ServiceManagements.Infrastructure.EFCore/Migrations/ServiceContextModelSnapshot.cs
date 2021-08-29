﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceManagements.Infrastructure.EFCore;

namespace ServiceManagements.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(ServiceContext))]
    partial class ServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceManagement.Domain.Plans.Plans", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlanDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanDescription9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PlanPrice")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("ServiceManagement.Domain.Services.Services", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceLogo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
