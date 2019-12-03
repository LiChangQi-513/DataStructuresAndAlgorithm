using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


           
            for (int x = 0; x <20; x++)
            {
                for (int y=0;y<33;y++)
                { 
                       int z = 100 - x - y;
                       if (x + y + z == 100 && 7*x+4*y==100)
                        { 
                            Console.WriteLine("{0} {1} {2}",x,y,z);

                        }
                        
                      

                       

                }
            }
            Console.ReadLine();
        }
    }
}
