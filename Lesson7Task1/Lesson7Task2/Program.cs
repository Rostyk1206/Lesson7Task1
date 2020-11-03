using System;
using System.Transactions;

namespace Lesson7Task2
{
    class Program
    {
        static string Question1()
        {
            while(true)
            {
                Console.WriteLine("Do you wanna Exit or Enter?");
                string enter ="enter";
                string exit = "exit";
                string answer = Console.ReadLine();
                if(answer==enter)
                {
                    return enter;
                }
                else if(answer==exit)
                {
                    return exit;
                }
            }
            
        }
        static string Question2()
        {
            while(true)
            {
                Console.WriteLine("Have you privilege or no?");
                string answer = Console.ReadLine();
                string privilege = "privilege";
                string no = "no";
                if (answer == privilege)
                {
                    return privilege;
                }
                else 
                {
                    return no;
                }
            }
        }
        static string PaySeven()
        {
            while(true)
            {
                Console.WriteLine("Please, put your 7 $");
                string pay = Console.ReadLine();
                if(pay=="7")
                {
                    Console.WriteLine("Thanks,welcome");
                    return pay;
                }
                else
                {
                    Console.WriteLine("Please,give 7$");
                }

            }
        }
        static string Privilege()
        {
            while(true)
            {
                Console.WriteLine("Please, pay 3 $");
                string pay = Console.ReadLine();

                if(pay=="3")
                {
                    Console.WriteLine("Thanks,welcome");
                    return pay;
                }
                else
                {
                    Console.WriteLine("Please,give 3 $");
                }
            }
        }
        static void CountingPerson(int count)
        {
            Console.WriteLine($"How many people:{count}");
            
        }
        static void Main(string[] args)
        {
            int count = 0;
            while(count<=21)
            {
                string answer=Question1();

                if (answer == "enter")
                {
                    string answer1 = Question2();
                    if(answer1=="no")
                    {
                        string answer2 = PaySeven();
                        count++;
                        CountingPerson(count);
                    }
                    else if(answer1=="privilege")
                    {
                        string answer3 = Privilege();
                        count++;
                        CountingPerson(count);
                    }
                }
                else if(answer=="exit")
                {
                    Console.WriteLine("Please,go out");
                    count--;
                    CountingPerson(count);
                    continue;
                }
            }

           
        }
    }
}
