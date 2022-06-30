﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTourGuyTest.Domain.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<Person> Persons { get; set; }

        public Role()
        {
            Persons = new HashSet<Person>();
        }
    }
}
