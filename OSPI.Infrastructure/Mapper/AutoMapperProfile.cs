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
                .ForMember(d => d.ModuleId, map => map.MapFrom(s => s.ModuleId))
                .ForMember(d => d.ModuleName, map => map.MapFrom(s => s.ModuleName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<RoleEntity, RoleModel>()
                .ForMember(d => d.RoleId, map => map.MapFrom(s => s.RoleId))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.RoleName))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ForMember(d => d.RoleAccesses, map => map.MapFrom(s => s.RoleAccesses))
                .ReverseMap()
                .ForPath(s => s.RoleAccesses, map => map.Ignore());

            CreateMap<RoleAccessEntity, RoleAccessModel>()
                .ForMember(d => d.RoleAccessId, map => map.MapFrom(s => s.RoleAccessId))
                .ForMember(d => d.RoleId, map => map.MapFrom(s => s.RoleId))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.Role.RoleName))
                .ForMember(d => d.ModuleId, map => map.MapFrom(s => s.ModuleId))
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
                .ForMember(d => d.MemberId, map => map.MapFrom(s => s.MemberId))
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
                .ForMember(d => d.RoleId, map => map.MapFrom(s => s.RoleId))
                .ForMember(d => d.Voted, map => map.MapFrom(s => s.Voted))
                .ForMember(d => d.RoleName, map => map.MapFrom(s => s.Role.RoleName))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Role.RoleName, map => map.Ignore());

            CreateMap<BallotEntity, BallotModel>()
                .ForMember(d => d.BallotId, map => map.MapFrom(s => s.BallotId))
                .ForMember(d => d.RefCode, map => map.MapFrom(s => s.RefCode))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Description))
                .ForMember(d => d.RegStartDate, map => map.MapFrom(s => s.RegStartDate))
                .ForMember(d => d.RegEndDate, map => map.MapFrom(s => s.RegEndDate))
                .ForMember(d => d.VotingStartDate, map => map.MapFrom(s => s.VotingStartDate))
                .ForMember(d => d.VotingEndDate, map => map.MapFrom(s => s.VotingEndDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ForMember(d => d.Positions, map => map.MapFrom(s => s.Positions))
                .ReverseMap()
                .ForPath(s => s.Positions, map => map.Ignore());

            CreateMap<PositionEntity, PositionModel>()
                .ForMember(d => d.PositionId, map => map.MapFrom(s => s.PositionId))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.PositionName))
                .ForMember(d => d.MinimumRequiredVotes, map => map.MapFrom(s => s.MinimumRequiredVotes))
                .ForMember(d => d.MaximumRequiredVotes, map => map.MapFrom(s => s.MaximumRequiredVotes))
                .ForMember(d => d.Qualifications, map => map.MapFrom(s => s.Qualifications))
                .ForMember(d => d.BallotId, map => map.MapFrom(s => s.BallotId))
                .ForMember(d => d.RefCode, map => map.MapFrom(s => s.Ballot.RefCode))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Ballot.Description))
                .ForMember(d => d.RegStartDate, map => map.MapFrom(s => s.Ballot.RegStartDate))
                .ForMember(d => d.RegEndDate, map => map.MapFrom(s => s.Ballot.RegEndDate))
                .ForMember(d => d.VotingStartDate, map => map.MapFrom(s => s.Ballot.VotingStartDate))
                .ForMember(d => d.VotingEndDate, map => map.MapFrom(s => s.Ballot.VotingEndDate))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Ballot.RefCode, map => map.Ignore())
                .ForPath(s => s.Ballot.Description, map => map.Ignore())
                .ForPath(s => s.Ballot.RegStartDate, map => map.Ignore())
                .ForPath(s => s.Ballot.RegEndDate, map => map.Ignore())
                .ForPath(s => s.Ballot.VotingStartDate, map => map.Ignore())
                .ForPath(s => s.Ballot.VotingEndDate, map => map.Ignore());

            CreateMap<CandidateEntity, CandidateModel>()
                .ForMember(d => d.CandidateId, map => map.MapFrom(s => s.CandidateId))
                .ForMember(d => d.CandidateMemberId, map => map.MapFrom(s => s.CandidateMemberId))
                .ForMember(d => d.PositionId, map => map.MapFrom(s => s.PositionId))
                .ForMember(d => d.NomineeMemberId, map => map.MapFrom(s => s.NomineeMemberId))
                .ForMember(d => d.Status, map => map.MapFrom(s => s.Status))
                .ForMember(d => d.CandidateMemberNo, map => map.MapFrom(s => s.CandidateMember.MemberNo))
                .ForMember(d => d.CandidateFirstName, map => map.MapFrom(s => s.CandidateMember.FirstName))
                .ForMember(d => d.CandidateLastName, map => map.MapFrom(s => s.CandidateMember.LastName))
                .ForMember(d => d.CandidateEmail, map => map.MapFrom(s => s.CandidateMember.EmailAddress))
                .ForMember(d => d.NomineeFirstName, map => map.MapFrom(s => s.NomineeMember.FirstName))
                .ForMember(d => d.NomineeLastName, map => map.MapFrom(s => s.NomineeMember.LastName))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.Position.PositionName))
                .ForMember(d => d.Votes, map => map.MapFrom(s => s.Votes))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.CandidateMember.MemberNo, map => map.Ignore())
                .ForPath(s => s.CandidateMember.FirstName, map => map.Ignore())
                .ForPath(s => s.CandidateMember.LastName, map => map.Ignore())
                .ForPath(s => s.CandidateMember.EmailAddress, map => map.Ignore())
                .ForPath(s => s.NomineeMember.FirstName, map => map.Ignore())
                .ForPath(s => s.NomineeMember.LastName, map => map.Ignore())
                .ForPath(s => s.Position.PositionName, map => map.Ignore())
                .ForPath(s => s.Votes, map => map.Ignore());

            CreateMap<ElectionEntity, ElectionModel>()
                .ForMember(d => d.ElectionId, map => map.MapFrom(s => s.ElectionId))
                .ForMember(d => d.DateVoted, map => map.MapFrom(s => s.DateVoted))
                .ForMember(d => d.MemberId, map => map.MapFrom(s => s.MemberId))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.Member.FirstName))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.Member.LastName))
                .ForMember(d => d.BallotId, map => map.MapFrom(s => s.BallotId))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Ballot.Description))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Member.FirstName, map => map.Ignore())
                .ForPath(s => s.Member.LastName, map => map.Ignore())
                .ForPath(s => s.Ballot.Description, map => map.Ignore());

            CreateMap<ElectionDetailEntity, ElectionDetailModel>()
                .ForMember(d => d.ElectionDetailId, map => map.MapFrom(s => s.ElectionDetailId))
                .ForMember(d => d.ElectionId, map => map.MapFrom(s => s.ElectionId))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Election.Ballot.Description))
                .ForMember(d => d.CandidateId, map => map.MapFrom(s => s.CandidateId))
                .ForMember(d => d.PositionName, map => map.MapFrom(s => s.Candidate.Position.PositionName))
                .ForMember(d => d.FirstName, map => map.MapFrom(s => s.Candidate.CandidateMember.FirstName))
                .ForMember(d => d.LastName, map => map.MapFrom(s => s.Candidate.CandidateMember.LastName))
                .ForMember(d => d.VFirstName, map => map.MapFrom(s => s.Election.Member.FirstName))
                .ForMember(d => d.VLastName, map => map.MapFrom(s => s.Election.Member.LastName))
                .ForMember(d => d.Plataforma, map => map.MapFrom(s => s.Candidate.Plataforma))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap()
                .ForPath(s => s.Election.Ballot.Description, map => map.Ignore())
                .ForPath(s => s.Candidate.Position.PositionName, map => map.Ignore())
                .ForPath(s => s.Candidate.CandidateMember.FirstName, map => map.Ignore())
                .ForPath(s => s.Candidate.CandidateMember.LastName, map => map.Ignore())
                .ForPath(s => s.Election.Member.FirstName, map => map.Ignore())
                .ForPath(s => s.Election.Member.LastName, map => map.Ignore())
                .ForPath(s => s.Candidate.Plataforma, map => map.Ignore());
        }
    }
}