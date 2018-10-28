using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class DictionarysMenu //FUNCTION AND EXECUTION
    {
        public static Dictionary<object, object> dictionary = new Dictionary<object, object>();
        DictionaryData diction = new DictionaryData(dictionary);
        public void DictionaryMenu()
        {
            try
            {

                Console.WriteLine("DICTIONARY MENU");
                Console.WriteLine("1. Add an Key Value Pair (Caution: Dictionary cannot have duplicate keys)");
                Console.WriteLine("2. Modify a Value for a Key");
                Console.WriteLine("3. Delete a Key Value Pair");
                Console.WriteLine("4. Clear the Dictionary");
                Console.WriteLine("5. View the Dictionary");
                Console.WriteLine("6. Return to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        diction.AddPair();
                        break;
                    case "2":
                        diction.Modify();
                        break;
                    case "3":
                        diction.DeletePair();
                        break;
                    case "4":
                        diction.Clear();
                        break;
                    case "5":
                        diction.ViewDictionary();
                        break;
                    case "6":
                        Program.Menu();
                        break;
                    default:
                        DictionaryMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong... try again");
                Console.ReadLine();
                DictionaryMenu();
            }
        }
    }
}
