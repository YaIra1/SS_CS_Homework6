using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Homework6
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
           // CollectionTask();
            DictionaryTask();
        }

        /// <summary>
        /// Declare collection myColl of 10 integers (read from console).
	    ///1) Find and print all positions of element “-10” in this collection;
	    ///2) Remove from collection elements, which are greater then 20.  Print new collection;
	    ///3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection;
	    ///4) Sort and print collection
        /// </summary>
        public static void CollectionTask()
        {
            var myColl = new List<int>();
            Console.WriteLine("Enter 10 integer numbers separeted by ' ':");
            string userInput = Console.ReadLine();
            string[] stringNumbers = userInput.Split();
            foreach (string strNumber in stringNumbers)
            {
                int.TryParse(strNumber, out int parsedNumber);
                myColl.Add(parsedNumber);
            }

            Console.Write("The indexes of -10 in collection: ");

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine();

            //find all elements less 20
            var newColl = myColl.Where(x => x <= 20).ToList();

            Console.Write("Elements less than 20 in collection: ");

            foreach (int elem in newColl)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            //remove items
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }
            Console.Write("Collection after remowing elements less than 20: ");

            foreach (int elem in myColl)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            if (myColl.Count >= 2)
            {
                myColl.Insert(2, 1);
            }

            if (myColl.Count >= 8)
            {
                myColl.Insert(8, -3);
            }

            if (myColl.Count >= 5)
            {
                myColl.Insert(5, -4);
            }

            Console.Write("Collection after inserting elements: ");

            foreach (int elem in myColl)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            myColl.Sort();

            Console.Write("Collection after sorting: ");

            foreach (int elem in myColl)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Create Console Application project in VS. 
        /// In the Main() method declare Dictionary<uint, string>.
        /// Add to Dictionary from Console 7 pairs(ID, Name) of some persons.
        ///Ask user to enter ID, then find and write corresponding Name from your Dictionary.
        /// If you can't find this ID - say about it to user. 
        /// </summary>
        public static void DictionaryTask()
        {
            var myDictionary = new Dictionary<uint, string>();

            const int personsCount = 7;

            for (int i = 1; i <= personsCount; i++)
            {
                Console.WriteLine($"Enter data for person #{i} in format: <id> <name>");
                var userInput = Console.ReadLine();
                var splittedInput = userInput.Split();
                uint.TryParse(splittedInput[0], out uint id);

                if (myDictionary.ContainsKey(id))
                {
                    Console.WriteLine($"Such id {id} already exists. Enter valid id and name.");
                    i--;
                }
                else
                {
                    myDictionary.Add(id, splittedInput[1]);
                }
            }
            Console.Write("Enter person's id: ");
            var inputId = Console.ReadLine();
            uint.TryParse(inputId, out uint personId);

            if (myDictionary.ContainsKey(personId))
            {
                Console.WriteLine($"The name of person for id {personId} is {myDictionary[personId]}");
            }
            else
            {
                Console.WriteLine($"There is no such id {personId}");
            }
        }
    }
}