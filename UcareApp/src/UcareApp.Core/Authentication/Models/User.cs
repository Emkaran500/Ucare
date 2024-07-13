using UcareApp.Core.Authentication.Enums;

namespace UcareApp.Core.Authentication.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public GenderEnum Gender { get; set; }
    public string Password { get; set; }
    public bool EmailVerified { get; set; }
}