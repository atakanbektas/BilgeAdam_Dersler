using System;
using System.Collections.Generic;

namespace UserLoginDBFirst.Models;

public partial class Human
{
    public int HumanId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public int? Age { get; set; }

    public long? Phone { get; set; }

    public virtual ICollection<Profile> Profiles { get; } = new List<Profile>();
}
