using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
   public class VariableRepository
    {
        // POST/DELETE ONE/GET ALL/DELETE ALL

        public VariableContext Context { get; set; }        //  ???      What does this do again?

        public VariableRepository()     //          Constructor for database interaction
        {
            Context = new VariableContext();
        }

        public VariableRepository(VariableContext _context)         //          Constructor for Moq testing
        {
            Context = _context;
        }

        public void AddVariable(Variable variable)      //          ??? Why do I need two add methods?
        {
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }

        public void AddVariable(string Name, int Value)     //      Method to add a new variable
        {
            Variable variable = new Variable { VarName = Name, VarValue = Value };
            Context.Variables.Add(variable);
            Context.SaveChanges();
        }

        public List<Variable> GetAllVariables()     //          Getting all variables and creating a list
        {
            return Context.Variables.ToList();
        }

        public void DeleteAllVariables()        //          Method to delete ALL variables
        {
            List<Variable> all_variables = Context.Variables.ToList();
            foreach (var variable in all_variables)
            {
                Context.Variables.Remove(variable);
            }
        
        }
                                                            //          Method to find a variable by name
        public Variable FindVariableByName(string Name)     // ???         Do I need to generate a list when I know that I will have code to check that a variable is not used in two places?
        {
            List<Variable> found_variables = Context.Variables.ToList();
            foreach (var variable in found_variables)
            {
                if (variable.VarName.ToLower() == Name.ToLower())
                {
                    return variable;
                }
            }
            return null;        // ???     Why do I need this again?
        }

        public Variable RemoveVariable(string Name)     //          Method to delete a single variable by name
        {
            Variable found_variable = FindVariableByName(Name);
            if (found_variable != null)
            {
                Context.Variables.Remove(found_variable);
                Context.SaveChanges();
            }
            return found_variable;      //  ???         What is this line doing besides returning a value to satisfy return type requirement for the class?

        }

        
    }
}
