using System.ComponentModel.DataAnnotations;

namespace Trackit.Domain.Entity;

public class BaseEntity
{
  [Key]
  public Guid Id { get; init; } = Guid.NewGuid();
  public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
  public DateTime? UpdatedAt { get; set; }
}