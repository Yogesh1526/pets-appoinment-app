using HealingPaws.Shared.RequestModel;

namespace HealingPaws.Shared.ResponseModel;

public class PetOwnerResponseModel : BaseResponseModel
{
    public string Name { get; set; }
    public int AddressId { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public List<PetResponseModel> Pets { get; set; }
    public AddressResponseModel Address { get; set; }
}
