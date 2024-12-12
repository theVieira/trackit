using BCrypt.Net;
using Trackit.Util;

namespace Trackit.Domain.Entity;

public class Tech : BaseEntity
{
  public string Name { get; set; } = string.Empty;
  public string Password { get; private set; } = string.Empty;
  public bool Status { get; set; } = true;
  public TechRole Role { get; set; }
  public string? Phone { get; set; } = string.Empty;
  public string? Email { get; set; } = string.Empty;

  public Tech() { }

  public Tech(string name, string password, TechRole role, string? phone, string? email)
  {
    Name = SpellCheck.CapitalizeName(name);
    Password = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
    Role = role;
    Phone = SpellCheck.CleanSpecialCharacters(phone);
    Email = email;
  }
}

public enum TechRole
{
  Admin,
  User,
  Manager,
  Tech
}