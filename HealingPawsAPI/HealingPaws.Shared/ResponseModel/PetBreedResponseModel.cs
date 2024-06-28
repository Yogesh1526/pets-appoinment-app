using HealingPaws.Shared.RequestModel;

namespace HealingPaws.Shared.ResponseModel;
public class PetBreedResponseModel: BaseResponseModel
{
    public string Name { get; set; }
    public int PetTypeId { get; set; }
    public PetTypeResponseModel PetType { get; set; }
}

