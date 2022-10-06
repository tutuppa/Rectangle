using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int w = 0;
            int option;
            int count = 0;
            {
                Console.WriteLine("***Rectangle calculations***");

                do
                {
                    count++;
                    if (count != 0)
                    {
                        Console.WriteLine("Please enter values greater than 0");
                    }
                    Console.WriteLine("\nPlease enter length\t ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter width\t ");
                    w = Convert.ToInt32(Console.ReadLine());
                }
                while (l <= 0 || w <= 0);

                do
                {
                    Console.WriteLine("\nChoose an option from the Menu\n 1. Get Rectangle Length \n2.Change Rectangle Length \n3.Get Rectangle Width \n4.Change Rectangle Width \n5.Get Rectangle Perimeter \n6.Get Rectangle Area \n7.Exit \n ");
                    option = Convert.ToInt32(Console.ReadLine());
                    Rectangle rc = new Rectangle(l, w);
                    if (option == 1)
                    {
                        Console.WriteLine("Rectangle length is ");
                        Console.WriteLine(rc.GetLength());
                    }
                    else if (option == 2)
                    {
                        do
                        {
                            Console.WriteLine("Enter a new length greater than 0");
                            l = Convert.ToInt32(Console.ReadLine());
                        } while (l < 1);
                        rc.SetLength(l);
                        Console.WriteLine("New rectangle length is ");
                        Console.WriteLine(rc.GetLength());
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("Rectangle width is ");
                        Console.WriteLine(rc.GetWidth());
                    }
                    else if (option == 4)
                    {
                        do
                        {
                            Console.WriteLine("Enter a new width greater than 0");
                            w = Convert.ToInt32(Console.ReadLine());
                        } while (w < 1);
                        rc.SetWidth(w);
                        Console.WriteLine("New rectangle width is ");
                        Console.WriteLine(rc.GetWidth());

                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("Rectangle perimeter is ");
                        Console.WriteLine(rc.GetPerimeter());

                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Rectangle Area is ");
                        Console.WriteLine(rc.GetArea());
                    }


                } while (option != 7);

            }
        }
    }
}
