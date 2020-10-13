﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20201013071031_CutePetMigration")]
    partial class CutePetMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("DataAccess.Models.OrdersList", b =>
                {
                    b.Property<int>("OrdersListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ordrOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("prorProductId")
                        .HasColumnType("int");

                    b.HasKey("OrdersListId");

                    b.HasIndex("ordrOrderId");

                    b.HasIndex("prorProductId");

                    b.ToTable("ordersList");
                });

            modelBuilder.Entity("DataAccess.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("DataAccess.Models.Tags", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ordrOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("prorProductId")
                        .HasColumnType("int");

                    b.HasKey("TagId");

                    b.HasIndex("UserId");

                    b.HasIndex("ordrOrderId");

                    b.HasIndex("prorProductId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DataAccess.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Old")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Models.OrdersList", b =>
                {
                    b.HasOne("DataAccess.Models.Orders", "ordr")
                        .WithMany()
                        .HasForeignKey("ordrOrderId");

                    b.HasOne("DataAccess.Models.Products", "pror")
                        .WithMany()
                        .HasForeignKey("prorProductId");
                });

            modelBuilder.Entity("DataAccess.Models.Tags", b =>
                {
                    b.HasOne("DataAccess.Models.Users", "usr")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Orders", "ordr")
                        .WithMany()
                        .HasForeignKey("ordrOrderId");

                    b.HasOne("DataAccess.Models.Products", "pror")
                        .WithMany()
                        .HasForeignKey("prorProductId");
                });
#pragma warning restore 612, 618
        }
    }
}