namespace HealingPaws.DataAccess.Entities;

public class PetOwnerEntity : BaseEntity
{
    public string Name { get; set; }
    public int AddressId { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public AddressEntity Address { get; set; }
    public List<PetEntity> Pets { get; set; }
}
