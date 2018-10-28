using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionConsole
{
    public class HashsMenu //FUNCTION AND EXECUTION
    {
        public static Hashtable hash = new Hashtable();
        HashData hashdata = new HashData(hash);
        public void HashMenu()
        {
            try
            {

                Console.WriteLine("HASHTABLE MENU");
                Console.WriteLine("1. Add a new Key Value Pair");
                Console.WriteLine("2. Modify a Value for a Key");
                Console.WriteLine("3. Delete a Key Value Pair");
                Console.WriteLine("4. View the Hash Table");
                Console.WriteLine("5. Return to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        hashdata.AddPair();
                        break;
                    case "2":
                        hashdata.Modify();
                        break;
                    case "3":
                        hashdata.DeletePair();
                        break;
                    case "4":
                        hashdata.ViewTable();
                        break;
                    case "5":
                        Program.Menu();
                        break;
                    default:
                        HashMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong... try again");
                Console.ReadLine();
                HashMenu();
            }
        }

    }
}
