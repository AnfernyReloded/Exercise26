using System;
using System.Collections.Generic;

namespace Counting_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string user_String;
                int vow_Count = 0;
                int con_Count = 0;

                //using an array with vowels would be more robust
                Console.WriteLine("Please enter a string");
                user_String = Console.ReadLine().ToLower();

                //By adding special characters into the replace method I could makes sure that they're counted too!
                string mod_string = user_String.Replace(" ", string.Empty);



                //write a method that uses an array to identify special chars and remove them from a string
                //building a method to count types of letters would be more robust
                foreach (char v in mod_string)
                {
                    if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                    {
                        vow_Count++;
                    }
                    else
                    {
                        con_Count++;
                    }

                }

                Console.WriteLine("The number of consonants = " + vow_Count);
                Console.WriteLine("Would you like to input another word? Y or N");
                string user_Choice = Console.ReadLine().ToLower();

                if (user_Choice == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }


            }


        }
    }
}

