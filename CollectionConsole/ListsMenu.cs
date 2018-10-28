using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class ListsMenu //FUNCTION AND EXECUTION
    {
        public static List<object> list = new List<object>();
        ListData listing = new ListData(list);
        public void ListMenu()
        {
            try
            {

                Console.WriteLine("LIST MENU");
                Console.WriteLine("1. Add an item to the end of the list");
                Console.WriteLine("2. Modify an item");
                Console.WriteLine("3. Delete an item");
                Console.WriteLine("4. Sort the list");
                Console.WriteLine("5. View the list");
                Console.WriteLine("6. Insert an item within the list");
                Console.WriteLine("7. Reverse the list");
                Console.WriteLine("8. Return to Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        listing.AddList();
                        break;
                    case "2":
                        listing.ModifyList();
                        break;
                    case "3":
                        listing.DeleteList();
                        break;
                    case "4":
                        listing.SortList();
                        break;
                    case "5":
                        listing.ViewList();
                        break;
                    case "6":
                        listing.InsertList();
                        break;
                    case "7":
                        listing.ReverseList();
                        break;
                    case "8":
                        Program.Menu();
                        break;
                    default:
                        ListMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong... try again");
                Console.ReadLine();
                ListMenu();
            }
        }

    }
}
