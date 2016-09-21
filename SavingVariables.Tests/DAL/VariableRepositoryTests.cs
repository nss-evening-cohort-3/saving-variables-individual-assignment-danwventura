using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SavingVariables.DAL;
using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.Tests.DAL
{
    [TestClass]
    class VariableRepositoryTests
    {
        Mock<VariableContext> mock_context { get; set; }
        Mock<DbSet<Variable>> mock_variable_table { get; set; }
        List<Variable> variable_list { get; set; }
        VariableRepository repo { get; set; }
        
        
    }
}
