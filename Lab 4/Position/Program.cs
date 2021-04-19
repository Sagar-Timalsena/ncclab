using System; 

using System.Text; 

  

namespace SwapChar 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            string str = "Palindrome"; 

            var word = new StringBuilder(); 

            word.Append(str); 

  

            var temp = word[0]; 

            word[0] = word[word.Length-1]; 

            word[word.Length-1] = temp;   

  

            Console.WriteLine(str + " => " + word); 

        } 

    } 

} 