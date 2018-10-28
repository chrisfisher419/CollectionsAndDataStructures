using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class StacksMenu//FUNCTION AND EXECUTION
    {
        public static Stack<object> stack = new Stack<object>();
        StackData stacking = new StackData(stack);
        public void StackMenu()
        {
            try
            {
                
                Console.Clear();
                Console.WriteLine("STACK MENU");
                Console.WriteLine("1. Add an item to the stack");
                Console.WriteLine("2. Remove an item from the stack");
                Console.WriteLine("3. Clear the stack");
                Console.WriteLine("4. View the stack");
                Console.WriteLine("5. Return to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        stacking.AddStack();
                        break;
                    case "2":
                        stacking.RemoveStack();
                        break;
                    case "3":
                        stacking.ClearStack();
                        break;
                    case "4":
                        stacking.ViewStack();
                        break;
                    case "5":
                        Program.Menu();
                        break;
                    //case "6":
                    //    stacking.Serialization();
                    //    break;
                    default:
                        StackMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong... try again");
                Console.ReadLine();
                StackMenu();
            }
        }
    }
}
