﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {
                
        }
    }
}
