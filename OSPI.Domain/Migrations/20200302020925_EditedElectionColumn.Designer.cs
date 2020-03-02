﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPI.Domain;

namespace OSPI.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200302020925_EditedElectionColumn")]
    partial class EditedElectionColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OSPI.Domain.Entities.BallotEntity", b =>
                {
                    b.Property<Guid>("BallotId")
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

                    b.HasKey("BallotId");

                    b.ToTable("Ballots");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.CandidateEntity", b =>
                {
                    b.Property<Guid>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateMemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("NomineeMemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Plataforma")
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("PositionId")
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

                    b.HasKey("CandidateId");

                    b.HasIndex("CandidateMemberId");

                    b.HasIndex("NomineeMemberId");

                    b.HasIndex("PositionId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ElectionDetailEntity", b =>
                {
                    b.Property<Guid>("ElectionDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("ElectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("ElectionDetailId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("ElectionId");

                    b.ToTable("ElectionDetails");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ElectionEntity", b =>
                {
                    b.Property<Guid>("ElectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BallotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DateVoted")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("ElectionId");

                    b.HasIndex("BallotId");

                    b.HasIndex("MemberId");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.MemberEntity", b =>
                {
                    b.Property<Guid>("MemberId")
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

                    b.Property<Guid>("RoleId")
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

                    b.Property<bool>("Voted")
                        .HasColumnType("bit");

                    b.HasKey("MemberId");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ModuleEntity", b =>
                {
                    b.Property<Guid>("ModuleId")
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

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.PositionEntity", b =>
                {
                    b.Property<Guid>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BallotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME");

                    b.Property<int>("MaximumRequiredVotes")
                        .HasColumnType("INT");

                    b.Property<int>("MinimumRequiredVotes")
                        .HasColumnType("INT");

                    b.Property<string>("PositionName")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Qualifications")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("PositionId");

                    b.HasIndex("BallotId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleAccessEntity", b =>
                {
                    b.Property<Guid>("RoleAccessId")
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

                    b.Property<Guid>("ModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("RoleAccessId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleAccesses");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleEntity", b =>
                {
                    b.Property<Guid>("RoleId")
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

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("OSPI.Domain.Entities.CandidateEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "CandidateMember")
                        .WithMany()
                        .HasForeignKey("CandidateMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "NomineeMember")
                        .WithMany()
                        .HasForeignKey("NomineeMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.PositionEntity", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ElectionDetailEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.CandidateEntity", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.ElectionEntity", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.ElectionEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.BallotEntity", "Ballot")
                        .WithMany()
                        .HasForeignKey("BallotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.MemberEntity", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.MemberEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.PositionEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.BallotEntity", "Ballot")
                        .WithMany("Positions")
                        .HasForeignKey("BallotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSPI.Domain.Entities.RoleAccessEntity", b =>
                {
                    b.HasOne("OSPI.Domain.Entities.ModuleEntity", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSPI.Domain.Entities.RoleEntity", "Role")
                        .WithMany("RoleAccesses")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
