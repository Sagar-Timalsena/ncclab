using System; 
namespace LongestWord 
{ 

    class Program 

    { 
        static void Main(string[] args) 
        { 

            string line = "We are Anonymous. We are Legion. We do not forgive. We do not forget"; 

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None); 

            string word = ""; 

            int ctr = 0; 

            foreach (String s in words) 

            { 

                if (s.Length > ctr) 

                { 

                    word = s; 

                    ctr = s.Length; 

                } 

            }        

            Console.WriteLine ( "From the string ' " + line + " ' , ' " + word + "' is the longest word."); 

        } 

    } 

} 