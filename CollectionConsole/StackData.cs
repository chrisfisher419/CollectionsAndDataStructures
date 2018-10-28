using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    class StackData
    {
        Stack<object> Stack { get; set; } //PROPERTY

        public StackData(Stack<object> stack) //CONSTRUCTOR
        {
            Stack = stack;
        }

        public void Return() //RETURN TO MENU
        {
            StacksMenu stackmenu = new StacksMenu();
            stackmenu.StackMenu();
        }

        public void RemoveStack() //REMOVES LAST ITEM IN STACK
        {
            try
            {
             
                if (Stack.Count == 0)
                {
                    Console.WriteLine("Stack is already empty...");
                    Console.ReadLine();
                    Return();
                }
                DisplayStack();
                Console.WriteLine("Would you like to pop off the top element? y/n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        Stack.Pop();
                        Console.WriteLine("Push another? y/ n");
                        var choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "y":
                                RemoveStack();
                                break;
                            case "n":
                                Console.WriteLine("Returning to Stack Menu....");
                                Console.ReadLine();
                                Return();
                                break;
                            default:
                                Console.WriteLine("Invalid command, returning to Stack Menu...");
                                Console.ReadLine();
                                Return();
                                break;
                        }
                        break;
                    case "n":
                        Console.WriteLine("Returning to Stack Menu....");
                        Console.ReadLine();
                        Return();
                        break;
                    default:
                        Console.WriteLine("Invalid command, returning to Stack Menu...");
                        Console.ReadLine();
                        Return();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Remove) Something went wrong.... the stack may be empty...returning to Stack Menu");
                Console.ReadLine();
                Return();
            }

        }


        public void AddStack() //ADDS ITEM TO TOP OF STACK
        {
            try
            {
                DisplayStack();
                Console.WriteLine("What value do you want to push to the stack? If you would like to return, simply hit enter");
                var input = Console.ReadLine();
                if (input == "") //PROVIDES OPTION TO RETURN
                {

                    Console.WriteLine("Nothing added, Returning to menu...");
                    Return();
                }
                Stack.Push(input);
                while (input != "")
                {
                    Console.WriteLine("What value do you want to push to the stack? If you would like to return, simply hit enter");
                    input = Console.ReadLine();
                    if (input == "")
                        continue;
                    Stack.Push(input);
                }
                DisplayStack();
                Console.WriteLine("Returning to menu");
                Console.ReadLine();
                Return();
            }
            catch (Exception)
            {
                Console.WriteLine("(Add) Something went wrong...returning to Stack Menu...");
                Console.ReadLine();
                Return();
            }

        }

        public void ClearStack() //CLEARS STACK ENTIRELY
        {
            try
            {
                if (Stack.Count == 0)
                {
                    Console.WriteLine("Stack is already empty...");
                    Console.ReadLine();
                    Return();
                }
                DisplayStack();
                Console.WriteLine("Are you sure you want to clear the stack? y/n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        Console.WriteLine("Clearing stack...");
                        Stack.Clear();
                        break;
                    case "n":
                        Console.WriteLine("Returning to menu...");
                        Return();
                        break;
                    default:
                        Console.WriteLine("Not a valid command, try again...");
                        ClearStack();
                        break;
                }
                Console.WriteLine("Returning to menu...");
                Return();
            }
            catch (Exception)
            {
                Console.WriteLine("(Clear) Something went wrong...returning to Stack Menu");
                Console.ReadLine();
                Return();

            }
        }


        public void DisplayStack() //SHOWS TOP ITEM, AND THE ITEMS IN THE STACK, USED WITHIN METHODS
        {
            try
            {
                if (Stack.Count == 0)
                {
                    Console.WriteLine("Stack is currently empty");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("TOP OF THE STACK IS: ");
                    var peek = Stack.Peek();
                    Console.WriteLine(peek);
                    Console.WriteLine("There are currently {0} items in the stack...", Stack.Count);
                    Console.WriteLine("Items in the stack are....");
                    foreach (object item in Stack)
                        Console.WriteLine(item);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Display) Something went wrong... the stack may be empty... Returning to Stack Menu");
                Console.ReadLine();
                Return();

            }
        }


        public void ViewStack() //SHOWS TOP ITEM AND THE ITEMS IN THE STACK
        {
            try
            {
                if (Stack.Count == 0)
                {
                    Console.WriteLine("Stack is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("TOP OF THE STACK IS: ");
                    var peek = Stack.Peek();
                    Console.WriteLine(peek);
                    Console.WriteLine("There are currently {0} items in the stack...", Stack.Count);
                    Console.WriteLine("Items in the stack are....");
                    foreach (object item in Stack)
                        Console.WriteLine(item);
                    Console.ReadLine();
                    Return();
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("(Peek) Something went wrong... the stack may be empty.... Returning to Stack Menu");
                Console.ReadLine();
                Return();

            }




        }
    }
}
