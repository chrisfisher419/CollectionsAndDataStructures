using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CollectionConsole
{
    [Serializable]
    public class DictionaryData
    {
        //PROPERTY
        public Dictionary<object, object> Dictionary { get; set; } 


        public DictionaryData(Dictionary<object, object> dictionary) //CONSTRUCTOR
        {
            Dictionary = dictionary;
        }

        public void DisplayDictionary() //SIMILAR TO VIEW, BUT DISPLAYS THE DICTIONARY WITHIN EACH METHOD
        {
            try
            {
                if (Dictionary.Count == 0)
                {
                    Console.WriteLine("Dictionary is currently empty");
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("DICTIONARY: ");
                    foreach (KeyValuePair<object, object> kvp in Dictionary)
                    {
                        Console.WriteLine("Key = {0}, value = {1}", kvp.Key, kvp.Value);

                    }
                    Console.ReadLine();
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Display) Something went wrong... returning to dictionary menu....");
                Console.ReadLine();
                Return();
            }
        }

    
        public void ViewDictionary() //VIEW DICTIONARY OPTION
        {
            try
            {
                Console.Clear();
                if (Dictionary.Count == 0)
                {
                    Console.WriteLine("Dictionary is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("DICTIONARY: ");
                    foreach (KeyValuePair<object, object> kvp in Dictionary)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

                    }
                    Console.ReadLine();
                    Return();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(View) Something went wrong... returning to dictionary menu....");
                Console.ReadLine();
                Return();
            }
        }


        public void Return() //RETURN TO MENU
        {
            DictionarysMenu dictionarymenu = new DictionarysMenu();
            dictionarymenu.DictionaryMenu();
        }


        public void Clear()
        {
            try
            {
                Console.Clear();
                if (Dictionary.Count == 0)
                {
                    Console.WriteLine("Dictionary is already clear");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("Are you sure you want to clear? y/n");
                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "y":
                            Console.WriteLine("Clearing dictionary...");
                            Dictionary.Clear();
                            Console.WriteLine("Dictionary cleared, returning to dictionary menu..");
                            Console.ReadLine();
                            Return();
                            break;
                        case "n":
                            Console.WriteLine("Returning to dictionary menu...");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to dictionary menu");
                            Console.ReadLine();
                            Return();
                            break;

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Clear) Something went wrong...returning to dictionary menu");
                Console.ReadLine();
                Return();
            }
        }



        public void AddPair() //ADDS KEY VALUE PAIR TO DICTIONARY
        {
            try
            {
                Console.Clear();
                DisplayDictionary();
                Console.WriteLine("Enter the Key you would like to add (Caution: A dictionary cannot hold duplicate keys) OR Hit enter to return to the Menu");
                var key = Console.ReadLine();
                if (key == "") //PROVIDES A RETURN OPTION 
                {
                    Console.WriteLine("Nothing added, returning to dictionary menu...");
                    Console.ReadLine();
                    Return();
                }
                Console.WriteLine("Enter the value you would like to add");
                var value = Console.ReadLine();
                Dictionary.Add(key, value);
                Console.WriteLine("Added Key: {0} Value: {1}", key, value);
                Console.ReadLine();
                Console.WriteLine("Add another? y/n");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "y":
                        AddPair();
                        break;
                    case "n":
                        DisplayDictionary();
                        Console.WriteLine("Returning to dictionary menu...");
                        Console.ReadLine();
                        Return();
                        break;
                    default:
                        Console.WriteLine("Invalid command, returning to dictionary menu");
                        Console.ReadLine();
                        Return();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Add) Something went wrong...returning to dictionary menu");
                Console.ReadLine();
                Return();

            }
        }


        public void DeletePair() //DELETES KEY VALUE PAIR BY USING THE KEY
        {
            try
            {
                Console.Clear();
                if (Dictionary.Count == 0)
                {
                    Console.WriteLine("Dictionary is already empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayDictionary();
                    Console.WriteLine("Which Key Value pair would you like to delete? (Input the Key...) OR Hit enter to return to the Menu");
                    var key = Console.ReadLine();
                    if (key == "")
                    {
                        Console.WriteLine("Returning to dictionary menu");
                        Console.ReadLine();
                        Return();
                    }
                    Dictionary.Remove(key);
                    Console.WriteLine("Pair removed...remove another? y/n");
                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "y":
                            DeletePair();
                            break;
                        case "n":
                            DisplayDictionary();
                            Console.WriteLine("Returning to dictionary menu");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to dictionary menu");
                            Console.ReadLine();
                            Return();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Delete) Something went wrong...returning to dictionary menu");
                Console.ReadLine();
                Return();

            }

        }

                
        public void Modify() //USED TO MODIFY THE VALUE FOR ANY EXISTING KEY
        {
            try
            {
                Console.Clear();
                if (Dictionary.Count == 0)
                {
                    Console.WriteLine("Dictionary is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayDictionary();
                    Console.WriteLine("Type the key for the value you would like to modify OR Hit enter to return to the menu");
                    var input = Console.ReadLine();
                    if (input == "")
                    {
                        Console.WriteLine("Returning to dictionary menu");
                        Console.ReadLine();
                        Return();
                    }
                    bool contains = Dictionary.ContainsKey(input);
                    if (contains == false)
                    {
                        Console.WriteLine("That key is not contained in the dictionary, try again");
                        Console.ReadLine();
                        Modify();
                    }
                    else if (contains == true)
                    {
                        Console.WriteLine("Enter the new value for the Key");
                        var value = Console.ReadLine();
                        if (value == "")
                        {
                            Console.WriteLine("Please enter a value next time");
                            Console.ReadLine();
                            Modify();
                        }
                        Dictionary[input] = value;
                        Console.WriteLine("New value is " + value);
                        DisplayDictionary();
                    }
                    Console.WriteLine("Modify another key? value y/n");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "y":
                            Modify();
                            break;
                        case "n":
                            DisplayDictionary();
                            Console.WriteLine("Returning to dictionary menu");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to dictionary menu");
                            Console.ReadLine();
                            Return();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Modify) Something went wrong...returning to dictionary menu");
                Console.ReadLine();
                Return();

            }
        }
        public void Serialization()
        {
            Console.Clear();
            Console.WriteLine("Serializing");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\chris\Serialize\dictionary.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, Dictionary);
            stream.Close();
            Console.WriteLine("Serialized....returning to menu");
            Return();
        }

    }
}
