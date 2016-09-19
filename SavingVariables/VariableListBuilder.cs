using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    class VariableListBuilder
    {
        public virtual List<Variable> VariablesList { get; set; }

        //private int i = 0;
        public void Add_Variable_To_List(string user_variable_name, int user_variable_value)
        {
            Variable new_user_variable = new Variable()
            {
                VarName = user_variable_name,
                VarValue = user_variable_value,
                //VariableId = i++
                
            };


            VariablesList.Add(new_user_variable);
        }
    }


}
