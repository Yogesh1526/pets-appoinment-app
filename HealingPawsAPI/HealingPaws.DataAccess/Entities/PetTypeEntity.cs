namespace HealingPaws.DataAccess.Entities;

public class PetTypeEntity : BaseEntity
{
    public string Name { get; set; }
    public List<PetEntity > Pets { get; set; }
    public List<PetBreedEntity > PetBreeds { get; set; }
}
