using Trackit.Util;

namespace Trackit.Domain.Entity;

public class Client : BaseEntity
{
  public string Name { get; set; } = string.Empty;
  public string CNPJ { get; set; } = string.Empty;
  public string? Phone { get; set; } = string.Empty;
  public string? Email { get; set; } = string.Empty;
  public bool Status { get; set; } = true;

  public Client() { }

  public Client(string name, string cnpj, string? phone, string? email) 
  {
    Name = SpellCheck.CapitalizeName(name);
    CNPJ = SpellCheck.CleanSpecialCharacters(cnpj);
    Phone = SpellCheck.CleanSpecialCharacters(phone);
    Email = email;
  }
}