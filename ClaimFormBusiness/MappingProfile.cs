using AutoMapper;
using ClaimFormBusiness.Dtos;
using SAOCPSEDB.Models;

namespace ClaimFormBusiness
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClmfrmClaimX, ClmfrmClaimXDto>();
        }
    }
}