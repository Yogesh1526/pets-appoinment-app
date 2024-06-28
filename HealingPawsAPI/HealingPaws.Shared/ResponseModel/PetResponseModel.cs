using HealingPaws.Shared.RequestModel;

namespace HealingPaws.Shared.ResponseModel;

public class PetResponseModel: BaseResponseModel
{
    public string Name { get; set; }
    public int PetTypeId { get; set; }
    public int PetBreedId { get; set; }
    public int PetOwnerId { get; set; }
    public PetTypeResponseModel PetType { get; set; }
    public PetBreedResponseModel PetBreed { get; set; }
    public PetOwnerResponseModel PetOwner { get; set; }
}
