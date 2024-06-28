namespace HealingPaws.DataAccess.Entities;

public class AppointmentEntity : BaseEntity
{
    public DateTime AppointmentDate { get; set; }
    public int PetOwnerId { get; set; }
    public int PetId { get; set; }
    public string Reason { get; set; }
    public PetOwnerEntity PetOwner { get; set; }   
    public PetEntity Pet { get; set; }
}
