﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Store.Domain;

namespace Online_Store.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Store.Domain.Entities.Category1Entity", b =>
                {
                    b.Property<Guid>("Cat1ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cat1Code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cat1Desc")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cat1Img")
                        .HasColumnType("varchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Cat1ID");

                    b.ToTable("Category1s");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category2Entity", b =>
                {
                    b.Property<Guid>("Cat2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Cat1ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cat2Code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cat2Desc")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cat2Img")
                        .HasColumnType("varchar(max)");

                    b.Property<Guid?>("Category1Cat1ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Cat2ID");

                    b.HasIndex("Category1Cat1ID");

                    b.ToTable("Category2s");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category3Entity", b =>
                {
                    b.Property<Guid>("Cat3ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Cat2ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cat3Code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cat3Desc")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cat3Img")
                        .HasColumnType("varchar(max)");

                    b.Property<Guid?>("Category2Cat2ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Cat3ID");

                    b.HasIndex("Category2Cat2ID");

                    b.ToTable("Category3s");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("ProdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Barcode")
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("Cat3ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Category3Cat3ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LongDesc")
                        .HasColumnType("varchar(100)");

                    b.Property<double>("MarkupAmount")
                        .HasColumnType("float");

                    b.Property<double>("MarkupPercent")
                        .HasColumnType("float");

                    b.Property<double>("MaxStock")
                        .HasColumnType("float");

                    b.Property<double>("Mintock")
                        .HasColumnType("float");

                    b.Property<Guid?>("OUMUOMID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProdCode")
                        .HasColumnType("varchar(10)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Stock")
                        .HasColumnType("float");

                    b.Property<long>("UOMID")
                        .HasColumnType("bigint");

                    b.Property<double>("UnitQty")
                        .HasColumnType("float");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Vatable")
                        .HasColumnType("bit");

                    b.HasKey("ProdID");

                    b.HasIndex("Category3Cat3ID");

                    b.HasIndex("OUMUOMID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.TestEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(10)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Desc")
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.UOMEntity", b =>
                {
                    b.Property<Guid>("UOMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UOMCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UOMDesc")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("UOMID");

                    b.ToTable("UOMs");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category2Entity", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Category1Entity", "Category1")
                        .WithMany()
                        .HasForeignKey("Category1Cat1ID");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category3Entity", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Category2Entity", "Category2")
                        .WithMany()
                        .HasForeignKey("Category2Cat2ID");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.ProductEntity", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Category3Entity", "Category3")
                        .WithMany("ProductEntity")
                        .HasForeignKey("Category3Cat3ID");

                    b.HasOne("Online_Store.Domain.Entities.UOMEntity", "OUM")
                        .WithMany("ProductEntity")
                        .HasForeignKey("OUMUOMID");
                });
#pragma warning restore 612, 618
        }
    }
}
