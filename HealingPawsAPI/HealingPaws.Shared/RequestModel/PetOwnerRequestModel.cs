namespace HealingPaws.Shared.RequestModel;
public class PetOwnerRequestModel: BaseRequestModel
{
    public string Name { get; set; }
    public int AddressId { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
}
