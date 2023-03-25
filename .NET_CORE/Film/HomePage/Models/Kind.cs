﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Kind
    {
        public int KindId { get; set; }
        public string? KindName { get; set; }
        public virtual ICollection<Film>? Films { get; set; } = new List<Film>();
    }
}
