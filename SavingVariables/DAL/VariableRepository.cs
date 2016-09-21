using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
    class VariableRepository
    {
        // POST/DELETE ONE/GET ALL/DELETE ALL

        public VariableContext Context { get; set; }

        public VariableRepository()     //          Constructor for database interaction
        {
            Context = new VariableContext();
        }

        public VariableRepository(VariableContext _context)         //          Constructor for Moq testing
        {
            Context = _context;
        }

        public void AddVariable(Variable variable)
        {
            Context.Variables.Add(variable);
        }

        public List<Variable> GetAllVariables()
        {
            return Context.Variables.ToList();
        }
    }
}
