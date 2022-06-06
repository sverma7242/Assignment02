using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int r_l;
                int r_w;

                int checkint()
                {
                    int value;
                    do
                    {

                        while (int.TryParse(Console.ReadLine(), out value) == false)
                        {
                            Console.Write("Please only enter positive integer values : ");
                        }

                    } while (value <= 0);

                    //Console.WriteLine(value);
                    return value;
                }


                Console.WriteLine("=================================");
                Console.WriteLine("\nWelcome to The Rectangle Wizard\n");
                Console.WriteLine("=================================");
                Console.ReadLine(); 
                Console.WriteLine("Please Enter Values below to initiate Rectangle\n");

                Console.WriteLine("\nLENGTH -> ");
                r_l = checkint();


                Console.WriteLine("\nWIDTH -> ");
                r_w = checkint();


                Rectangle r1 = new Rectangle(r_l, r_w);

                System.Console.WriteLine("\nRectangle Created!\n=================================");
                int option;
                do
                {
                    Console.Clear();
                    System.Console.WriteLine(" 1.Get Rectangle Length \n 2.Change Rectangle Length \n 3.Get Rectangle Width \n 4.Change Rectangle Width \n 5.Get Rectangle Perimeter \n 6.Get Rectangle Area \n 7.Exit");
                    Console.WriteLine("=================================");
                    System.Console.WriteLine("\nSelect an option from the Menu");

                    option = checkint();
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine($"Rectangle Length is {r1.GetLength()}");
                                Console.ReadLine();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter new length ->");
                                r1.SetLength(checkint());
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"Rectangle Width is {r1.GetWidth()}");
                                Console.ReadLine();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter new width ->");
                                r1.SetWidth(checkint());
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine($"Rectangle Perimeter is {r1.GetPerimeter()}");
                                Console.ReadLine();
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine($"Rectangle Area is {r1.GetArea()}");
                                Console.ReadLine();
                                break;
                            }
                        case 7:
                            {
                                Environment.Exit(-1);
                                break;
                            }

                    }

                } while (option != 7);




            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);

            }
            System.Console.ReadLine();




        }
    }
}
