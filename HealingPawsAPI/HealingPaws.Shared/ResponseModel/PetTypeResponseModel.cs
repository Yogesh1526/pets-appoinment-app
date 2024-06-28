
using HealingPaws.Shared.RequestModel;

namespace HealingPaws.Shared.ResponseModel;

public class PetTypeResponseModel: BaseResponseModel
{
    public string Name { get; set; }
    public List<PetBreedResponseModel> PetBreeds { get; set; }
}
