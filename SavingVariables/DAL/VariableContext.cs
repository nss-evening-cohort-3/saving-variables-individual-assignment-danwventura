﻿using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SavingVariables.DAL
{
    public class VariableContext : DbContext
    {

        public virtual DbSet<Variable> Variables { get; set; } 

    }
}
