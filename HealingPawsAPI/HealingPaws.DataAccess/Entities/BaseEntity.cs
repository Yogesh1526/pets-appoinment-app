using System.ComponentModel.DataAnnotations;

namespace HealingPaws.DataAccess.Entities;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; } 
    public DateTime? CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? IsDeleted { get; set; }
}
