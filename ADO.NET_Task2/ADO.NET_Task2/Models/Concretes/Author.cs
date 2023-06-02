﻿using ADO.NET_Task2.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task2.Models.Concretes
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{Id} {FirstName} {LastName}";
    }
}
