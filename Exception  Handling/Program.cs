using System;

namespace Exception__Handling
{
    class MyException:Exception
    {
        public MyException()
        {
            Console.WriteLine("Thrown exception");
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // start program for first time to cought divide by zero exception
            // after for second time change num2 to a non zero number to catch my exception
            int num1 = 10;
            int num2 = 0; ;
            try
            {
                num1 = num1 / num2;
                throw new MyException();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Invalid Division");
            }
            catch(MyException)
            {
                Console.WriteLine("we cought my exception");

            }
            finally
            {
                Console.WriteLine("i am compiling always");
            }

        }
    }
}
