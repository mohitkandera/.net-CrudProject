using System;
using System.Collections.Generic;

namespace CRUD_Project_DatabaseFisrtAPP.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string Email { get; set; } = null!;

    public string? Password { get; set; }
}
