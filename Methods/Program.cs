using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();//instance object from class program 
            p.EvenNumbers(30);//instance Method need instance object from class to invoke and for every object it can be called with different  prameters
            int FirstNumber = 20;
            int SecondNumber = 50;
            Program.Add(FirstNumber,SecondNumber);//static Method called with class name not with object  
            int i = 0;
            Program p1 = new Program();
            //p1.SimpleFunction(i);//passinyg by value so it will not change because i and j referes to different memory locations
            p1.SimpleFunction(ref i);//passing by refernece making i and j refers to same location and when function change it will affect all
            Console.WriteLine(i);

           
        }
        //simple method
        public void SimpleFunction(ref int j)
        {
            j = 100;
        }
        //making method for even numbers 
        public void EvenNumbers(int Target)
        {
            for (int i = 2; i <= Target; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Add(int FirstNumber,int SecondNumber)
        {
            long Sum = FirstNumber + SecondNumber;
            Console.WriteLine("Sum is {0}",Sum);
            
            
        }
    }
}
