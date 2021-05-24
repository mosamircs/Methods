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

            //using out parameter to return more than one value from Method
            int Sum;
            int Mul;
            int Sub;
            int Div;
            SimpleCalculator(10,5,out Sum, out Mul, out Sub, out Div);
            Console.WriteLine("Sum is {0} and Sub is {1} and Mul is {2} and Div is {3}",Sum,Sub,Mul,Div);

            //parameters array
            string[] Names = new string[5];
            Names[0] = "Moahamed";
            Names[1] = "Samir";
            Names[2] = "mosamircs";
            Names[3] = "MO";
            Names[4] = "s";
            ParamsArray();//works that making params array 
            ParamsArray("ss", "ss", "mm", "ssss");//passing any number of arguments
            ParamsArray(Names);

        }

        //params array 
        public static void ParamsArray(params string[] Names)
        {
            Console.WriteLine("Length of Array is{0}", Names.Length);
            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }
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
        public static void SimpleCalculator(int FirstNumber,int SecondNumber,out int Sum, out int Mul,out int Sub,out int Div)
        {
            Sum = FirstNumber + SecondNumber;
            Sub = FirstNumber - SecondNumber;
            Mul = FirstNumber * SecondNumber;
            try
            {
                Div = FirstNumber / SecondNumber;
            }catch(Exception e)
            {
                Div = 0;
                Console.WriteLine(e.ToString());
            }
            
        }
        static void Add(int FirstNumber,int SecondNumber)
        {
            long Sum = FirstNumber + SecondNumber;
            Console.WriteLine("Sum is {0}",Sum);          
        }
    }
}
