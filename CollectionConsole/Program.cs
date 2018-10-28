using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
      
            Menu();


        }
        public static void Menu()
        {
            try
            {
                ListsMenu listmenu = new ListsMenu();
                StacksMenu stackmenu = new StacksMenu();
                QueuesMenu queuemenu = new QueuesMenu();
                DictionarysMenu dictionarymenu = new DictionarysMenu();
                HashsMenu hashmenu = new HashsMenu();


                Console.WriteLine("What would you like to work with?");
                Console.WriteLine("1. Lists");
                Console.WriteLine("2. Stacks");
                Console.WriteLine("3. Queues");
                Console.WriteLine("4. Dictionaries");
                Console.WriteLine("5. Hash Tables");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        listmenu.ListMenu();
                        break;
                    case "2":
                        stackmenu.StackMenu();
                        break;
                    case "3":
                        queuemenu.QueueMenu();
                        break;
                    case "4":
                        dictionarymenu.DictionaryMenu();
                        break;
                    case "5":
                        hashmenu.HashMenu();
                        break;
                    default:
                        Menu();
                        break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong...try again");
                Console.ReadLine();
                Menu();
            }
            
        }
        


    }
}
