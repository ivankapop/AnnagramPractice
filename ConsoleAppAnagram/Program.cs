using System;
using System.Text;

namespace ConsoleAppAnagram
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("Hello again, Mykola!");
            Console.WriteLine("Please enter the text, that should be changed ...");
            string text = Console.ReadLine();

            string[] words = text.Split(' '); 

            var result = new StringBuilder(text.Length);

            foreach (var word in words){
               result.Append(ReverseOnlyLetters(new StringBuilder(word))); 
            }

            Console.WriteLine();
            Console.WriteLine($"Here is result ---> {result}"); 
            Console.ReadLine();
        }

        static StringBuilder ReverseOnlyLetters(StringBuilder word){
            int right = word.Length - 1;
            int left = 0; 

            while (left < right){
                if (!char.IsLetter(word[left]))
                    left++;
                else if (!char.IsLetter(word[right]))
                    right--;
                else {
                    char tmp = word[left];
                    word[left] = word[right];
                    word[right] = tmp;
                    left++;
                    right--;
                }
            }
            return word.Append(" ");
        }
    }
}
