using System;
using System.Collections.Generic;

namespace UserLoginDBFirst.Models;

public partial class Profile
{
    public string ProfileId { get; set; } = null!;

    public string? Password { get; set; }

    public int? HumanId { get; set; }

    public virtual Human? Human { get; set; }
}
