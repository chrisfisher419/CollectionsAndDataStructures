using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionConsole
{
    public class HashData
    {
        Hashtable Hash{ get; set; } //PROPERTY

        public HashData(Hashtable hash) //CONSTRUCTOR
        {
            Hash = hash;
        }

        public void Return()
        {
            HashsMenu hashmenu = new HashsMenu();
            hashmenu.HashMenu();
        }

        public void ViewTable() //VIEWS THE TABLE
        {
            try
            {
                if (Hash.Count == 0)
                {
                    Console.WriteLine("Table is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    Console.WriteLine("HASH TABLE");
                    foreach (var key in Hash.Keys)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", key, Hash[key]);
                    }
                    Console.ReadLine();
                    Return();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(View) Something went wrong...returning to Hash Menu");
                Console.ReadLine();
                Return();
            }
        }

        public void DisplayTable() //SIMILAR TO VIEW, BUT DISPLAYS TABLE WITHIN METHODS
        {
            try
            {
                if (Hash.Count == 0)
                {
                    Console.WriteLine("Table is currently empty");
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("HASH TABLE");
                    foreach (var key in Hash.Keys)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", key, Hash[key]);
                    }
                    Console.ReadLine();
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Display) Something went wrong...returning to Hash Table Menu");
                Console.ReadLine();
                Return();
            }

        }


        public void AddPair() //ADDS A KEY VALUE PAIR
        {
            try
            {
                DisplayTable();
                Console.WriteLine("Enter the key you would like to add. (Caution: A Hash Table CANNOT null keys or values) OR hit enter to return to the menu");
                var key = Console.ReadLine();
                if (key == "") //PROVIDES AN OPTION TO RETURN
                {
                    Console.WriteLine("Nothing added, returning to hash table menu...");
                    Console.ReadLine();
                    Return();
                }
                Console.WriteLine("Enter the value you would like to add");
                var value = Console.ReadLine();
                Hash.Add(key, value);

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
                        DisplayTable();
                        Console.WriteLine("Returning to hash table menu...");
                        Console.ReadLine();
                        Return();
                        break;
                    default:
                        Console.WriteLine("Invalid command, returning to hash table menu");
                        Console.ReadLine();
                        Return();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Add) Something went wrong...returning to hash table menu");
                Console.ReadLine();
                Return();

            }
        }


        public void DeletePair() //DELETES KEY VALUE PAIR BY USING KEY
        {
            try
            {
                if (Hash.Count == 0)
                {
                    Console.WriteLine("Hash table is already empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayTable();
                    Console.WriteLine("Which Key Value pair would you like to delete? (Input the Key...) OR Hit enter to return to the Menu");
                    var key = Console.ReadLine();
                    if (key == "")
                    {
                        Console.WriteLine("Returning to hash table menu");
                        Console.ReadLine();
                        Return();
                    }
                    Hash.Remove(key);
                    Console.WriteLine("Pair removed...remove another? y/n");
                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "y":
                            DeletePair();
                            break;
                        case "n":
                            DisplayTable();
                            Console.WriteLine("Returning to hash table menu");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to hash table menu");
                            Console.ReadLine();
                            Return();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Delete)Something went wrong...returning to hash table menu");
                Console.ReadLine();
                Return();

            }

        }


        public void Modify() //MODIFIES THE VALUE FOR A GIVEN KEY
        {
            try
            {
                if (Hash.Count == 0)
                {
                    Console.WriteLine("Hash table is currently empty");
                    Console.ReadLine();
                    Return();
                }
                else
                {
                    DisplayTable();
                    Console.WriteLine("Type the key for the value you would like to modify OR Hit enter to return to the menu");
                    var input = Console.ReadLine();
                    if (input == "")
                    {
                        Console.WriteLine("Returning to hash table menu");
                        Console.ReadLine();
                        Return();
                    }
                    bool contains = Hash.ContainsKey(input);
                    if (contains == false)
                    {
                        Console.WriteLine("That key is not contained in the hash table, try again");
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
                        Hash[input] = value;
                        Console.WriteLine("New value is " + value);
                        DisplayTable();
                    }
                    Console.WriteLine("Modify another key? value y/n");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "y":
                            Modify();
                            break;
                        case "n":
                            DisplayTable();
                            Console.WriteLine("Returning to hash table menu");
                            Console.ReadLine();
                            Return();
                            break;
                        default:
                            Console.WriteLine("Invalid command, returning to hash table menu");
                            Console.ReadLine();
                            Return();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Modify)Something went wrong...returning to dictionary menu");
                Console.ReadLine();
                Return();

            }
        }

    }
}
