using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            //List<string> javaList = new List<string>() { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            //while (true)
            //    Console.WriteLine(RepeatCount(javaList, Console.ReadLine()));

            //question 2
            while (true)
                Push5Pop5();
        }

        /// <summary>
        /// Question 1
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        static int RepeatCount(List<string> strings, string word)
        {
            int counter = 0;

            string wordClone = word; //thought about stringbuilder but it doesn't have some methods that string has

            for (int i = 0; i < strings.Count; i++)
            {
                counter++;
                foreach (var letter in strings[i])
                {
                    if (wordClone.Contains(letter))
                    {
                        wordClone = wordClone.Remove(wordClone.IndexOf(letter), 1);
                    }
                    else
                    {
                        counter--;
                        wordClone = ""; //reset here so the length checker won't reduce the counter twice, weird workaround but it works
                        break;
                    }
                }
                if (wordClone.Length != 0)
                    counter--;
                wordClone = word;
            }



            return counter;
        }

        public static void Push5Pop5()
        {
            NumberCollection nums = new NumberCollection();
            nums.PrintAll();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a number to push, anything that is not a number is considered 0:");
                int enteredNumber = 0;
                int.TryParse(Console.ReadLine(), out enteredNumber);
                nums.Push(enteredNumber);
                nums.PrintAll();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("press ENTER to pop the next number");
                Console.ReadLine();
                Console.WriteLine("popped " + nums.Pop());

                nums.PrintAll();
            }
        }
    }
}
