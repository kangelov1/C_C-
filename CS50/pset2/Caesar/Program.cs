using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int key = int.Parse(Console.ReadLine());
            int[] array = new int[word.Length];

            for(int i = 0; i < word.Length; i++)
            {
                if(char.IsLower(word[i]))
                {
                    array[i] = word[i] - 97;
                }
                else if (char.IsUpper(word[i]))
                {
                    array[i] = word[i] - 65;
                }
                else
                {
                    array[i] = word[i];
                }
            }
            for(int i = 0; i <array.Length; i++)
            {
                int offset = 0;
                if (char.IsLower(word[i]))
                {
                    offset = 97;
                }
                else if (char.IsUpper(word[i]))
                {
                    offset = 65;
                }
                Console.WriteLine(array[i] + offset);
            }
        }
    }
}
