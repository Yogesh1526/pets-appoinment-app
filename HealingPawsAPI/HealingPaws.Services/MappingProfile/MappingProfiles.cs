using AutoMapper;
using HealingPaws.DataAccess.Entities;
using HealingPaws.Shared.RequestModel;
using HealingPaws.Shared.ResponseModel;

namespace HealingPaws.Services.MappingProfile;


public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AddressRequestModel, AddressEntity>();
        CreateMap<AddressEntity, AddressResponseModel>();

        CreateMap<AppointmentRequestModel, AppointmentEntity>();
        CreateMap<AppointmentEntity, AppointmentResponseModel>();

        CreateMap<PetBreedRequestModel, PetBreedEntity>();
        CreateMap<PetBreedEntity, PetBreedResponseModel>();

        CreateMap<PetOwnerRequestModel, PetOwnerEntity>();
        CreateMap<PetOwnerEntity, PetOwnerResponseModel>();

        CreateMap<PetRequestModel, PetEntity>();
        CreateMap<PetEntity, PetResponseModel>();

        CreateMap<PetTypeRequestModel, PetTypeEntity>();
        CreateMap<PetTypeEntity, PetTypeResponseModel>();
    }
}