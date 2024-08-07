﻿using Microsoft.AspNetCore.Identity;

namespace UcareApp.Core.Auth.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
}
