using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class QueueData
    {
        public Queue<object> Queue { get; set; } //PROPERTY

        public QueueData(Queue<object> queue) //CONSTRUCTOR
        {
            Queue = queue;
        }

        public void Return() //RETURNS TO MENU
        {
            QueuesMenu queuemenu = new QueuesMenu();
            queuemenu.QueueMenu();
        }

        public void Enqueue() //ADDS ITEM TO QUEUE
        {
            try
            {
                DisplayQueue();
                Console.WriteLine("What would you like to add to the queue? If you would like to return, simply hit enter");
                var input = Console.ReadLine();

                if (input == "") //ALLOWS AN OPTION TO RETURN
                {
                    DisplayQueue();
                    Console.WriteLine("Nothing added, returning to menu...");
                    Return();
                }
                Queue.Enqueue(input);
                while (input != "")
                {
                    Console.WriteLine("What would you like to add to the queue? If you would like to return, simply hit enter");
                    input = Console.ReadLine();

                    if (input == "")
                        continue;
                    Queue.Enqueue(input);

                }
                DisplayQueue();
                Console.WriteLine("Returning to menu....");
                Console.ReadLine();
                Return();
            }
            catch (Exception)
            {
                Console.WriteLine("(Enqueue) Something went wrong... returning to menu");
                Console.ReadLine();
                Return();
            }

        }


        public void Dequeue() //REMOVES ITEM FROM QUEUE
        {
            try
            {
                if (Queue.Count == 0)
                {
                    Console.WriteLine("Queue is already empty...");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayQueue();
                    Console.WriteLine("Dequeue the first object? y/n");
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "y":
                            Console.WriteLine("Dequeueing....");
                            Queue.Dequeue();
                            DisplayQueue();
                            Console.WriteLine("Dequeue again? y/n");
                            var choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "y":
                                    Dequeue();
                                    break;
                                case "n":
                                    Console.WriteLine("Returning to Queue Menu....");
                                    Console.ReadLine();
                                    Return();
                                    break;
                                default:
                                    Console.WriteLine("Invalid command, returning to Queue Menu...");
                                    Console.ReadLine();
                                    Return();
                                    break;
                            }
                            break;
                        case "n":
                            Console.WriteLine("Returning to Queue Menu....");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to Queue Menu...");
                            Console.ReadLine();
                            Return();
                            break;

                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("(Dequeue) Something went wrong...returning to Queue Menu...");
                Console.ReadLine();
                Return();
            }

        }
        public void DisplayQueue() //SIMILAR TO VIEW, DISPLAYS FIRST ITEM IN QUEUE, AND  ALL ITEMS WITHIN THE QUEUE
        {
            try
            {
                if (Queue.Count == 0)
                {
                    Console.WriteLine("Queue is Empty");
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("First item in queue is: ");
                    var item = Queue.Peek();
                    Console.WriteLine(item);
                    Console.ReadLine();
                    Console.WriteLine("All items in the queue are: ");
                    foreach (var i in Queue)
                        Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Display) Something went wrong...Returning to Queue Menu");
                Console.ReadLine();
                Return();
            }
        }


        public void ViewQueue() //DISPLAYS THE FIRST ITEM IN QUEUE, AND ALL ITEMS WITHIN THE QUEUE
        {
            try
            {
                if (Queue.Count == 0)
                {
                    Console.WriteLine("Queue is Empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("First item in queue is: ");
                    var item = Queue.Peek();
                    Console.WriteLine(item);
                    Console.ReadLine();
                    Console.WriteLine("All items in the queue are: ");
                    foreach (var i in Queue)
                        Console.WriteLine(i);
                    Console.ReadLine();
                }
                Console.WriteLine("Returning to Queue Menu");
                Console.ReadLine();
                Return();
            }
            catch (Exception)
            {
                Console.WriteLine("(View) Something went wrong...Returning to Queue Menu");
                Console.ReadLine();
                Return();
            }
        }
    }
}
