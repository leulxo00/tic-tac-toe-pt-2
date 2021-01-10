using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program

    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1;

        static int choice;


        static int flag = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("[1] new game");
            Console.WriteLine("[2] about author");
            Console.WriteLine("[3] exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                do

                {

                    Console.Clear();

                    Console.WriteLine("Player1:X and Player2:O");

                    Console.WriteLine("\n");

                    if (player % 2 == 0)

                    {

                        Console.WriteLine("Player 2 Chance");

                    }

                    else

                    {

                        Console.WriteLine("Player 1 Chance");

                    }

                    Console.WriteLine("\n");

                    Board();

                    choice = int.Parse(Console.ReadLine());


                    if (arr[choice] != 'X' && arr[choice] != 'O')

                    {

                        if (player % 2 == 0)

                        {

                            arr[choice] = 'O';

                            player++;

                        }

                        else

                        {

                            arr[choice] = 'X';

                            player++;

                        }

                    }

                    else

                    {

                        Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                        Console.WriteLine("\n");

                        Console.WriteLine("Please wait 2 second board is loading again.....");

                        Thread.Sleep(2000);

                    }

                    flag = CheckWin();

                } while (flag != 1 && flag != -1);



                Console.Clear();

                Board();



                if (flag == 1)

                {

                    Console.WriteLine("Player {0} has won", (player % 2) + 1);

                }

                else

                {

                    Console.WriteLine("Draw");

                }

                Console.ReadLine();

            }



            static void Board()

            {

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

                Console.WriteLine("     |     |      ");

            }

            static int CheckWin()

            {

              



                if (arr[1] == arr[2] && arr[2] == arr[3])

                {

                    return 1;

                }



                else if (arr[4] == arr[5] && arr[5] == arr[6])

                {

                    return 1;

                }



                else if (arr[6] == arr[7] && arr[7] == arr[8])

                {

                    return 1;

                }

                else if (arr[1] == arr[4] && arr[4] == arr[7])

                {

                    return 1;

                }



                else if (arr[2] == arr[5] && arr[5] == arr[8])

                {

                    return 1;

                }



                else if (arr[3] == arr[6] && arr[6] == arr[9])

                {

                    return 1;

                }

                else if (arr[1] == arr[5] && arr[5] == arr[9])

                {

                    return 1;

                }

                else if (arr[3] == arr[5] && arr[5] == arr[7])

                {

                    return 1;

                }


                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

                {

                    return -1;

                }


                else

                {

                    return 0;

                }

            }
            if (input == "0") ;

            else if (input == "2")
            {
                Console.WriteLine("i am leulseged who syudies computer science at WSB Unversity. Hope you enjoy th game Good Luck!");
                
            }
            else if (input == "3")
            {
                Console.WriteLine("are you sure you want to exit?");
                Console.WriteLine("[1]yes");
                Console.WriteLine("[2]no");

                if (input == "1")
                { }
                else if (input == "2")
                { }

            }

        }
    }
}


