﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPI.Domain;

namespace OSPI.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OSPI.Domain.Entities.CandidateEntity", b =>
                {
                    b.Property<Guid>("CandidateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateMemberID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("NomineeMemberID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Plataforma")
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("PositionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Status")
                        .HasColumnType("char(30)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("CandidateID");

                    b.HasIndex("CandidateMemberID");

                    b.HasIndex("NomineeMemberID");

                    b.HasIndex("PositionID");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ElectionEntity", b =>
                {
                    b.Property<Guid>("ElectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("RefCode")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<DateTime>("RegEndDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("RegStartDate")
                        .HasColumnType("DATETIME");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("VotingEndDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("VotingStartDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("ElectionID");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.MemberEntity", b =>
                {
                    b.Property<Guid>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNo")
                        .HasColumnType("CHAR(30)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<double>("Capital")
                        .HasColumnType("FLOAT");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("CreditStatus")
                        .HasColumnType("CHAR(30)");

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("DATETIME");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("CHAR(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("CHAR(30)");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("LastName")
                        .HasColumnType("CHAR(30)");

                    b.Property<string>("MemberNo")
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("MemberStatus")
                        .HasColumnType("CHAR(30)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("CHAR(30)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Password")
                        .HasColumnType("CHAR(20)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<double>("Salary")
                        .HasColumnType("FLOAT");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("MemberID");

                    b.HasIndex("RoleID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ModuleEntity", b =>
                {
                    b.Property<Guid>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("ModuleName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("ModuleID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.PositionEntity", b =>
                {
                    b.Property<Guid>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("ElectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PositionName")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Qualifications")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<int>("RequiredCandidates")
                        .HasColumnType("INT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("PositionID");

                    b.HasIndex("ElectionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleAccessEntity", b =>
                {
                    b.Property<Guid>("RoleAccessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanAdd")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEdit")
                        .HasColumnType("bit");

                    b.Property<bool>("CanPrint")
                        .HasColumnType("bit");

                    b.Property<bool>("CanView")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("ModuleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("RoleAccessID");

                    b.HasIndex("ModuleID");

                    b.HasIndex("RoleID");

                    b.ToTable("RoleAccesses");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleEntity", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("RoleName")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.VoteDetailEntity", b =>
                {
                    b.Property<Guid>("VoteDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("VoteID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VoteDetailID");

                    b.HasIndex("CandidateID");

                    b.HasIndex("VoteID");

                    b.ToTable("VoteDetails");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.VoteEntity", b =>
                {
                    b.Property<Guid>("VoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DateVoted")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("ElectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("VoteID");

                    b.HasIndex("ElectionID");

                    b.HasIndex("MemberID");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.CandidateEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "CandidateMember")
                        .WithMany()
                        .HasForeignKey("CandidateMemberID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "NomineeMember")
                        .WithMany()
                        .HasForeignKey("NomineeMemberID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.PositionEntity", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.MemberEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.PositionEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.ElectionEntity", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleAccessEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.ModuleEntity", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.VoteDetailEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.CandidateEntity", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.VoteEntity", "Vote")
                        .WithMany()
                        .HasForeignKey("VoteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.VoteEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.ElectionEntity", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
