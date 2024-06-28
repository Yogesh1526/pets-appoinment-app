namespace HealingPaws.Shared.RequestModel;
public class AppointmentRequestModel: BaseRequestModel
{
    public DateTime AppointmentDate { get; set; }
    public int PetOwnerId { get; set; }
    public int PetId { get; set; }
    public string Reason { get; set; }
}
