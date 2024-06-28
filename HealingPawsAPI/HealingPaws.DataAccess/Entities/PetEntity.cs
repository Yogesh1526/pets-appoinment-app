namespace HealingPaws.DataAccess.Entities;

public class PetEntity : BaseEntity
{
    public string Name { get; set; }
    public int PetTypeId { get; set; }
    public int PetBreedId { get; set; }
    public int PetOwnerId { get; set; }
    public PetTypeEntity PetType { get; set; }
    public PetBreedEntity PetBreed { get; set; }
    public PetOwnerEntity PetOwner { get; set; }
}
