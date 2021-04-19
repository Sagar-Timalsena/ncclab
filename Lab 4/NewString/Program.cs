using System; 

using System.Text; 

  

namespace Copycat 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            string word = "Sagar"; 

            var term = new StringBuilder(); 

  

            if(word.Length < 2) 

            { 

                Console.WriteLine(word); 

            } 

            else 

            { 

                for(int i=0; i<4;i++) 

                { 

                    term.Append(word[0]+""+word[1]); 

                } 

                Console.WriteLine(term); 

            } 

        } 

    } 

} 