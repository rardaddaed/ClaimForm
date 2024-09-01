using AutoMapper;
using ClaimFormBusiness.Dtos;
using SAOCPSEDB.Models;

namespace SAOCPSEDB
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClmfrmClaimX, ClmfrmClaimXDto>();
        }
    }
}