using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionConsole
{
    public class ListData //MAINTAINS CLASS LOGIC
    {
        //PROPERTY 
        public List<object> List { get; set; }

        //CONSTRUCTOR 
        public ListData(List<object> list)
        {
            List = list;
        }

        //RETURNS TO LIST OPTION MENU
        public void Return()
        {
            ListsMenu listmenu = new ListsMenu();
            listmenu.ListMenu();
        }

        //QUICK LIST DISPLAY BEFORE EACH ACTION
        public void DisplayList()
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is currently empty");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("CURRENT LIST: ");
                    foreach (var i in List)
                    {
                        int pos = List.IndexOf(i);
                        Console.WriteLine("Value: " + i + " is at position: " + pos);

                    }
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Display) Something went wrong, returning to menu..");
                Console.ReadLine();
                Return();
            }

        }


        //LIST VIEW OPTION
        public void ViewList()
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("CURRENT LIST");
                    foreach (var i in List)
                    {
                        int pos = List.IndexOf(i);
                        Console.WriteLine("Value: " + i + " is at position: " + pos);
                    }
                    Console.ReadLine();
                    Console.WriteLine("Returning to menu....");
                    Return();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(View) Something went wrong...returning to menu");
                Console.ReadLine();
                Return();
            }
        }


        public void ReverseList() //REVERSES THE LIST IN THE ORDER THAT IT IS IN
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is empty...");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayList();
                    Console.WriteLine("Reversing list....");
                    List.Reverse();
                    DisplayList();
                    Console.WriteLine("Returning to menu....");
                    Return();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Reverse) Something went wrong...perhaps there are no values at the index you picked? Returning to List Menu");
                Console.ReadLine();
                Return();

            }
        }
        

        public void InsertList() //INSERTS AN ITEM AT A GIVE INDEX
        {
            try
            {
                DisplayList();
                Console.WriteLine("Enter the value that you want to insert...");
                var input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Please enter a value next time...");
                    Console.ReadLine();
                    InsertList();
                }
                Console.WriteLine("Enter the index of where you want that value to be...");
                int index = Convert.ToInt32(Console.ReadLine());
                List.Insert(index, input);
                DisplayList();
                Console.WriteLine("Insert another value? y/n");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "y":
                        InsertList();
                        break;
                    case "n":
                        Return();
                        break;
                    default:
                        Console.WriteLine("Invalid, returning to List Menu");
                        Return();
                        break;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("(Insert) Something went wrong... perhaps there are no values at the index you picked? Returning to List Menu");
                Console.ReadLine();
                Return();

            }


        }
        
        //SORTS THE LIST
        public void SortList()
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is empty...");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayList();
                    Console.WriteLine("Sorting list...");
                    List.Sort();
                    DisplayList();
                    Console.WriteLine("Returning to menu....");
                    Console.ReadLine();
                    Return();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Sort) Something went wrong...perhaps the list is empty? Returning to List Menu");
                Console.ReadLine();
                Return();
            }
        
        }

        //DELETES ITEM AT SPECIFIC INDEX
        public void DeleteList()
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is empty...");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayList();
                    Console.WriteLine("What position would you like to delete, position starts at 0, max position is: " + (List.Count - 1));
                    int input = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Selected: " + input);
                    List.RemoveAt(input);
                    Console.WriteLine("......Item Deleted");
                    DisplayList();
                    Console.WriteLine("1. Delete another value ");
                    Console.WriteLine("2. Return to List menu ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            DeleteList();
                            break;
                        case "2":
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid, returning to List Menu");
                            Return();
                            break;
                    }
                }
            

            }
            catch (Exception)
            {
                Console.WriteLine("(Delete) Something went wrong...perhaps there are no values at the index you picked? Returning to List Menu");
                Console.ReadLine();
                Return();

            }
        }

        //ADDS AN ITEM TO THE END OF THE LIST
        public void AddList()
        {
            try
            {
                DisplayList(); //DISPLAYS THE LIST BEFORE HAND
                Console.WriteLine("What would you like to enter? If you would like to return, simply hit enter");
                var input = Console.ReadLine(); //TAKES USER INPUT
                
                if (input == "") //MUST BE A VALUE
                {
                    DisplayList();
                    Console.WriteLine("Nothing added, Returning to menu....");
                    Return();
                }
                List.Add(input);
                while (input != "") //CONTINUE THE LOOP UNTIL NOTHING IS ENTERED
                {
                    Console.WriteLine("What would you like to enter? If you would like to return, simply hit enter");
                    input = Console.ReadLine();
                    if (input == "")
                        continue;
                    List.Add(input);
                }
                DisplayList();
                Console.WriteLine("Returning to menu....");
                 Console.ReadLine();
                Return();
            }
            catch (Exception)
            {
                Console.WriteLine("(Add) Something went wrong... returning to List Menu");
                Console.ReadLine();
                Return();
            }
                

        }
        public void ModifyList() //MODIFIES THE ITEM AT A POSITION
        {
            try
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is empty...");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayList();
                    Console.WriteLine("Which position would you like to modify, position starts at 0, max position is: " + (List.Count - 1)); //DISPLAY VALUE AND POS
                    int input = Convert.ToInt32(Console.ReadLine());
                    var value = List[input];

                    Console.WriteLine("Selected: " + value);
                    Console.WriteLine("What would you like to change this item to?");

                    var change = Console.ReadLine();
                    if (change == "")
                    {
                        Console.WriteLine("Enter a value next time");
                        Console.ReadLine();
                        ModifyList();
                    }
                    value = change;
                    List[input] = value;

                    Console.WriteLine("Value is now: " + value);
                    Console.ReadLine();
                    Console.WriteLine("1. Modify another value ");
                    Console.WriteLine("2. Return to List menu ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            ModifyList();
                            break;
                        case "2":
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid, returning to List Menu");
                            Return();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Modify) Something went wrong... returning to List Menu");
                Console.ReadLine();
                Return();
            }
            


        }



    }
}
