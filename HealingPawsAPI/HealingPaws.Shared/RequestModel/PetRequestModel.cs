using HealingPaws.Shared.ResponseModel;
using System.Text.Json.Serialization;

namespace HealingPaws.Shared.RequestModel;
public class PetRequestModel : BaseRequestModel
{
    public string Name { get; set; }
    public int PetTypeId { get; set; }
    public int PetBreedId { get; set; }
    public int PetOwnerId { get; set; }
}

