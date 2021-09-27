using System;

namespace firstcsharp
{
    class Program
    { 
         
        static void Main(string[] args)
        {
        int i = 1;

        for(i = 1; i <=255; i++){
         Console.WriteLine(i);
        }
        for(i = 1; i < 100; i++){
            if (i % 15 == 0){
                i++;
            }
            if (i % 3 == 0){
                Console.WriteLine(i);
            }
            if (i % 5 == 0){
                Console.WriteLine(i);
            } 
        }
                for(i = 1; i < 100; i++){
            if (i % 15 == 0){
                Console.WriteLine("Fizzbuzz");
            }
            if (i % 3 == 0){
                Console.WriteLine("Fizz");
            }
            if (i % 5 == 0){
                Console.WriteLine("Buzz");
            } 
        }


        }  
        }
    }

