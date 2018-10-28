using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsole
{
    public class QueuesMenu //FUNCTION AND EXECUTION
    {
        public static Queue<object> queue = new Queue<object>();
        QueueData queueing = new QueueData(queue);
        public void QueueMenu()
        {
            try
            {

                Console.WriteLine("QUEUE MENU");
                Console.WriteLine("1. Enqueue an item");
                Console.WriteLine("2. Dequeue an item");
                Console.WriteLine("3. View the queue");
                Console.WriteLine("4. Return the Main Menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        queueing.Enqueue();
                        break;
                    case "2":
                        queueing.Dequeue();
                        break;
                    case "3":
                        queueing.ViewQueue();
                        break;
                    case "4":
                        Program.Menu();
                        break;
                    default:
                        QueueMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Menu) Something went wrong... try again");
                Console.ReadLine();
                QueueMenu();
            }
        }

    }
}
