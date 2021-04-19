using System; 

namespace Average 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            Console.Write("Enter any four number: "); 

            var input = Console.ReadLine().Split(' '); 

  

            float num1 = int.Parse(input[0]); 

            float num2 = int.Parse(input[1]); 

            float num3 = int.Parse(input[2]); 

            float num4 = int.Parse(input[3]); 

  

            float average = (num1 + num2 + num3 + num4)/4; 

  

            Console.WriteLine("The average of 4 numbers is: "+ average); 

        } 

    } 

} 