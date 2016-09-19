using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    class VariableListBuilder       //          Helper class to build 
    {
        public virtual List<Variable> VariablesList { get; set; }

        
        public void Add_Variable_To_List(string user_variable_name, int user_variable_value)
        {
            Variable new_user_variable = new Variable()
            {
                VarName = user_variable_name,
                VarValue = user_variable_value,
                
                
            };


            VariablesList.Add(new_user_variable);
        }
    }


}
