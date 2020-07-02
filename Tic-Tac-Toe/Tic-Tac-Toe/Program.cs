using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool win = false;
            string one = "  |";
            string two = "   ";
            string three = "|  ";
            string four = "  |";
            string five = "   ";
            string six = "|  ";
            string seven = "  |";
            string eight = "   ";
            string nine = "|  ";
            string Inputx = "0";
            string Inputy = "0";
            int i = 0;
            int ii = 0;

            while (win == false)
            {
                Console.WriteLine("Plyer 1, choose the position on the x-axis.");
                while (i == 0)
                {
                    Inputx = Console.ReadLine();
                    int Inputxint = Convert.ToInt32(Inputx);
                    if (Inputxint > 3 || Inputxint < 1)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                    }
                    else
                    {
                        i = 1;
                    }
                }
                Console.WriteLine("");

                Console.WriteLine("Now the y-axis.");
                while (ii == 0)
                {
                    Inputy = Console.ReadLine();
                    int inputyint = Convert.ToInt32(Inputy);
                    if (inputyint > 3 || inputyint < 1)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                    }
                    else
                    {
                        ii = 1;
                    }
                }
                Console.WriteLine("");

                i = 0;
                ii = 0;

                if (Inputy == "1")
                {
                    if (Inputx == "1")
                    {
                        if (one == "x |" || one == "o |")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            one = "x |";
                        }
                    }

                    if (Inputx == "2")
                    {
                        if (two == " x " || two == " o ")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            two = " x ";
                        } 
                    }

                    if (Inputx == "3")
                    {
                        if (three == "| x" || three == "| o")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            three = "| x";
                        }    
                    }
                }

                if (Inputy == "2")
                {
                    if (Inputx == "1")
                    {
                        if (four == "x |" || four == "o |")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            four = "x |";
                        } 
                    }

                    if (Inputx == "2")
                    {
                        if (five == " x " || five == " o ")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            five = " x ";
                        }
                    }

                    if (Inputx == "3")
                    {
                        if (six == "| x" || six == "| o")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            six = "| x";
                        }
                    }
                }

                if (Inputy == "3")
                {
                    if (Inputx == "1")
                    {
                        if (seven == "x |" || seven == "o |")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            seven = "x |";
                        }   
                    }

                    if (Inputx == "2")
                    {
                        if (eight == " x " || eight == " o ")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            eight = " x ";
                        }
                    }

                    if (Inputx == "3")
                    {
                        if (nine == "| x" || nine == "| o")
                        {
                            Console.WriteLine("Please choose another field.");
                            Inputx = Console.ReadLine();
                            Inputy = Console.ReadLine();
                        }

                        else
                        {
                            nine = "| x";
                        }
                    }
                }

                Console.WriteLine(one + two + three);
                Console.WriteLine("---------");
                Console.WriteLine(four + five + six);
                Console.WriteLine("---------");
                Console.WriteLine(seven + eight + nine);
                Console.WriteLine("");

                if (one == "x |" && two == " x " && three == "| x" || one == "x |" && five == " x " && nine == "| x" || one == "x |" && four == "x |" && seven == "x |" || two == " x " && five == " x " && eight == " x " || three == "| x" && six == "| x" && nine == "| x" || four == "x |" && five == " x " && six == "| x" || seven == "x |" && eight == " x " && nine == "| x" || seven == "x |" && five == " x " && three == "| x")
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Environment.Exit(0);
                }

                Console.WriteLine("Player 2, choose the x axis.");
                while (i == 0)
                {
                    Inputx = Console.ReadLine();
                    int Inputxint = Convert.ToInt32(Inputx);
                    if (Inputxint > 3 || Inputxint < 1)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                    }
                    else
                    {
                        i = 1;
                    }
                }
                    Console.WriteLine("");

                    Console.WriteLine("Now the y-axis.");
                    while (ii == 0)
                    {
                        Inputy = Console.ReadLine();
                        int inputyint = Convert.ToInt32(Inputy);
                        if (inputyint > 3 || inputyint < 1)
                        {
                            Console.WriteLine("Please choose a number between 1 and 3.");
                        }
                        else
                        {
                            ii = 1;
                        }
                    }
                    Console.WriteLine("");

                    i = 0;
                    ii = 0;

                    if (Inputy == "1")
                    {
                        if (Inputx == "1")
                        {
                            if (one == "x |" || one == "o |")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                one = "o |";
                            }
                        }

                        if (Inputx == "2")
                        {
                            if (two == " x " || two == " o ")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                two = " o ";
                            }
                        }

                        if (Inputx == "3")
                        {
                            if (three == "| x" || three == "| o")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                three = "| o";
                            }
                        }
                    }

                    if (Inputy == "2")
                    {
                        if (Inputx == "1")
                        {
                            if (four == "x |" || four == "o |")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                four = "o |";
                            }
                        }

                        if (Inputx == "2")
                        {
                            if (five == " x " || five == " o ")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                five = " o ";
                            }
                        }

                        if (Inputx == "3")
                        {
                            if (six == "| x" || six == "| o")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                six = "| o";
                            }
                        }
                    }

                    if (Inputy == "3")
                    {
                        if (Inputx == "1")
                        {
                            if (seven == "x |" || seven == "o |")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                seven = "o |";
                            }
                        }

                        if (Inputx == "2")
                        {
                            if (eight == " x " || eight == " o ")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                eight = " o ";
                            }
                        }

                        if (Inputx == "3")
                        {
                            if (nine == "| x" || nine == "| o")
                            {
                                Console.WriteLine("Please choose another field.");
                                Inputx = Console.ReadLine();
                                Inputy = Console.ReadLine();
                            }

                            else
                            {
                                nine = "| o";
                            }     
                        }
                    }
                Console.WriteLine(one + two + three);
                Console.WriteLine("---------");
                Console.WriteLine(four + five + six);
                Console.WriteLine("---------");
                Console.WriteLine(seven + eight + nine);
                Console.WriteLine("");

                if (one == "o |" && two == " o " && three == "| o" || one == "o |" && five == " o " && nine == "| o" || one == "o |" && four == "o |" && seven == "o |" || two == " o " && five == " o " && eight == " o " || three == "| o" && six == "| o" && nine == "| o" || four == "o |" && five == " o " && six == "| o" || seven == "o |" && eight == " o " && nine == "| o" || seven == "o |" && five == " o " && three == "| o")
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
