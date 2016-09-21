using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SavingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VariableListBuilder build_this = new VariableListBuilder();

            
            bool continue_program = true;
            while (continue_program != false)
            {
                Console.WriteLine(">>");
                string user_entry = Console.ReadLine();
                Console.WriteLine(user_entry);
                Console.ReadKey();
            }


        }
    }
}
