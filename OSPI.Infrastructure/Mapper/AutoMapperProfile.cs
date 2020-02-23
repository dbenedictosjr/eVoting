﻿using OSPI.Domain.Entities;
using OSPI.Infrastructure.Models;
using AutoMapper;

namespace OSPI.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ModuleEntity, ModuleModel>()
                .ForMember(d => d.ModuleID, map => map.MapFrom(s => s.ModuleID))
                .ForMember(d => d.ModuleName, map => map.MapFrom(s => s.ModuleName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<RoleEntity, RoleModel>()
                .ForMember(d => d.RoleID, map => map.MapFrom(s => s.RoleID))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.RoleName))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<RoleAccessEntity, RoleAccessModel>()
                .ForMember(d => d.RoleAccessID, map => map.MapFrom(s => s.RoleAccessID))
                .ForMember(d => d.RoleID, map => map.MapFrom(s => s.RoleID))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.Role.RoleName))
                .ForMember(d => d.ModuleID, map => map.MapFrom(s => s.ModuleID))
                .ForMember(d => d.ModuleName, map => map.MapFrom(s => s.Module.ModuleName))
                .ForMember(d => d.CanAdd, map => map.MapFrom(s => s.CanAdd))
                .ForMember(d => d.CanEdit, map => map.MapFrom(s => s.CanEdit))
                .ForMember(d => d.CanDelete, map => map.MapFrom(s => s.CanDelete))
                .ForMember(d => d.CanView, map => map.MapFrom(s => s.CanView))
                .ForMember(d => d.CanPrint, map => map.MapFrom(s => s.CanPrint))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Role.RoleName, map => map.Ignore())
                .ForPath(s => s.Module.ModuleName, map => map.Ignore());

            CreateMap<MemberEntity, MemberModel>()
                .ForMember(d => d.MemberID, map => map.MapFrom(s => s.MemberID))
                .ForMember(d => d.MemberNo, map => map.MapFrom(s => s.MemberNo))
                .ForMember(d => d.RegistrationDate, map => map.MapFrom(s => s.RegistrationDate))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.FirstName))
                .ForMember(d => d.MiddleName, map => map.MapFrom(s => s.MiddleName))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.LastName))
                .ForMember(d => d.HomeAddress, map => map.MapFrom(s => s.HomeAddress))
                .ForMember(d => d.EmailAddress, map => map.MapFrom(s => s.EmailAddress))
                .ForMember(d => d.PhoneNo, map => map.MapFrom(s => s.PhoneNo))
                .ForMember(d => d.MobileNo, map => map.MapFrom(s => s.MobileNo))
                .ForMember(d => d.BirthDate, map => map.MapFrom(s => s.BirthDate))
                .ForMember(d => d.Capital, map => map.MapFrom(s => s.Capital))
                .ForMember(d => d.MemberStatus, map => map.MapFrom(s => s.MemberStatus))
                .ForMember(d => d.CreditStatus, map => map.MapFrom(s => s.CreditStatus))
                .ForMember(d => d.Password, map => map.MapFrom(s => s.Password))
                .ForMember(d => d.DateHired, map => map.MapFrom(s => s.DateHired))
                .ForMember(d => d.Salary, map => map.MapFrom(s => s.Salary))
                .ForMember(d => d.AccountNo, map => map.MapFrom(s => s.AccountNo))
                .ForMember(d => d.RoleID, map => map.MapFrom(s => s.RoleID))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.Role.RoleName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Role.RoleName, map => map.Ignore());

            CreateMap<ElectionEntity, ElectionModel>()
                .ForMember(d => d.ElectionID, map => map.MapFrom(s => s.ElectionID))
                .ForMember(d => d.RefCode, map => map.MapFrom(s => s.RefCode))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RegStartDate, map => map.MapFrom(s => s.RegStartDate))
                .ForMember(d => d.RegEndDate, map => map.MapFrom(s => s.RegEndDate))
                .ForMember(d => d.VotingStartDate, map => map.MapFrom(s => s.VotingStartDate))
                .ForMember(d => d.VotingEndDate, map => map.MapFrom(s => s.VotingEndDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<PositionEntity, PositionModel>()
                .ForMember(d => d.PositionID, map => map.MapFrom(s => s.PositionID))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.PositionName))
                .ForMember(d => d.RequiredCandidates, map => map.MapFrom(s => s.RequiredCandidates))
                .ForMember(d => d.Qualifications, map => map.MapFrom(s => s.Qualifications))
                .ForMember(d => d.ElectionID, map => map.MapFrom(s => s.ElectionID))
                .ForMember(d => d.RefCode, map => map.MapFrom(s => s.Election.RefCode))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Election.Description))
                .ForMember(d => d.RegStartDate, map => map.MapFrom(s => s.Election.RegStartDate))
                .ForMember(d => d.RegEndDate, map => map.MapFrom(s => s.Election.RegEndDate))
                .ForMember(d => d.VotingStartDate, map => map.MapFrom(s => s.Election.VotingStartDate))
                .ForMember(d => d.VotingEndDate, map => map.MapFrom(s => s.Election.VotingEndDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Election.RefCode, map => map.Ignore())
                .ForPath(s => s.Election.Description, map => map.Ignore())
                .ForPath(s => s.Election.RegStartDate, map => map.Ignore())
                .ForPath(s => s.Election.RegEndDate, map => map.Ignore())
                .ForPath(s => s.Election.VotingStartDate, map => map.Ignore())
                .ForPath(s => s.Election.VotingEndDate, map => map.Ignore());

            CreateMap<CandidateEntity, CandidateModel>()
                .ForMember(d => d.CandidateID, map => map.MapFrom(s => s.CandidateID))
                .ForMember(d => d.CandidateMemberID, map => map.MapFrom(s => s.CandidateMemberID))
                .ForMember(d => d.PositionID, map => map.MapFrom(s => s.PositionID))
                .ForMember(d => d.NomineeMemberID, map => map.MapFrom(s => s.NomineeMemberID))
                .ForMember(d => d.Status, map => map.MapFrom(s => s.Status))
                .ForMember(d => d.CandidateFirstName, map => map.MapFrom(s => s.CandidateMember.FirstName))
                .ForMember(d => d.CandidateLastName, map => map.MapFrom(s => s.CandidateMember.LastName))
                .ForMember(d => d.NomineeFirstName, map => map.MapFrom(s => s.NomineeMember.FirstName))
                .ForMember(d => d.NomineeLastName, map => map.MapFrom(s => s.NomineeMember.LastName))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.Position.PositionName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.CandidateMember.FirstName, map => map.Ignore())
                .ForPath(s => s.CandidateMember.LastName, map => map.Ignore())
                .ForPath(s => s.NomineeMember.FirstName, map => map.Ignore())
                .ForPath(s => s.NomineeMember.LastName, map => map.Ignore())
                .ForPath(s => s.Position.PositionName, map => map.Ignore());

            CreateMap<VoteEntity, VoteModel>()
                .ForMember(d => d.VoteID, map => map.MapFrom(s => s.VoteID))
                .ForMember(d => d.DateVoted, map => map.MapFrom(s => s.DateVoted))
                .ForMember(d => d.MemberID, map => map.MapFrom(s => s.MemberID))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.Member.FirstName))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.Member.LastName))
                .ForMember(d => d.ElectionID, map => map.MapFrom(s => s.ElectionID))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Election.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Member.FirstName, map => map.Ignore())
                .ForPath(s => s.Member.LastName, map => map.Ignore())
                .ForPath(s => s.Election.Description, map => map.Ignore());

            CreateMap<VoteDetailEntity, VoteDetailModel>()
                .ForMember(d => d.VoteDetailID, map => map.MapFrom(s => s.VoteDetailID))
                .ForMember(d => d.VoteID, map => map.MapFrom(s => s.VoteID))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Vote.Election.Description))
                .ForMember(d => d.CandidateID, map => map.MapFrom(s => s.CandidateID))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.Candidate.Position.PositionName))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.Candidate.CandidateMember.FirstName))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.Candidate.CandidateMember.LastName))
                .ForMember(d => d.Plataforma, map => map.MapFrom(s => s.Candidate.Plataforma))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Vote.Election.Description, map => map.Ignore())
                .ForPath(s => s.Candidate.Position.PositionName, map => map.Ignore())
                .ForPath(s => s.Candidate.CandidateMember.FirstName, map => map.Ignore())
                .ForPath(s => s.Candidate.CandidateMember.LastName, map => map.Ignore())
                .ForPath(s => s.Candidate.Plataforma, map => map.Ignore());
        }
    }
}