namespace HealingPaws.DataAccess.Entities;

public class PetBreedEntity : BaseEntity
{
    public string Name { get; set; }
    public int PetTypeId {  get; set; }
    public PetTypeEntity PetType { get; set; }
}
