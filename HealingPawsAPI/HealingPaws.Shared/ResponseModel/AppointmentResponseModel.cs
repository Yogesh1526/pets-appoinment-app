using HealingPaws.Shared.RequestModel;

namespace HealingPaws.Shared.ResponseModel;

public class AppointmentResponseModel: BaseResponseModel
{
    public DateTime AppointmentDate { get; set; }
    public int PetOwnerId { get; set; }
    public int PetId { get; set; }
    public string Reason { get; set; }
    public PetOwnerResponseModel PetOwner { get; set; }
    public PetResponseModel Pet { get;set; }
}
