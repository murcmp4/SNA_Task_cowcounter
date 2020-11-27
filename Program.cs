using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNA_Task_cowcounter
{
    class Program
    {
        static bool Compare(string entered, string randomed)
        {
            string outputToConsole = string.Empty;
            int cowCounter = 0;
            for (int i = 0; i < randomed.Length; i++)
            {
                if (randomed[i] == entered[i]) cowCounter++;
            }
            if (cowCounter == 4)
            {
                Console.WriteLine("Ура! 4 БЫКА Собрано!!");
                Console.WriteLine();
                return false;
            }
            else
            {
                switch (cowCounter)
                {
                    case 0:
                        outputToConsole = "Быков 0";
                        break;
                    case 1:
                        outputToConsole = "Быков 1";
                        break;
                    case 2:
                        outputToConsole = "Быков 2";
                        break;
                    case 3:
                        outputToConsole = "Быков 3";
                        break;
                }
            }

            int bikCounter = 0;
            string helptemp = string.Empty;
            for (int i = 0; i < randomed.Length; i++)
            {
                for (int j = 0; j < entered.Length; j++)
                {
                    if (randomed[i] == entered[j] && helptemp.IndexOf(j.ToString()) == -1)
                    {
                        helptemp += j.ToString();
                        bikCounter++;
                        break;
                    }
                }
            }

            switch (bikCounter)
            {
                case 0:
                    outputToConsole += " Коров 0";
                    break;
                case 1:
                    outputToConsole += " Коров 1";
                    break;
                case 2:
                    outputToConsole += " Коров 2";
                    break;
                case 3:
                    outputToConsole += " Коров 3";
                    break;
                case 4:
                    outputToConsole += " Коров 4";
                    break;

            }

            Console.WriteLine(outputToConsole);
            return (true);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                string current = string.Empty;
                string enter = string.Empty;

                for (int i = 0; i < 4; i++)
                    current += rnd.Next(10).ToString();

                //Console.WriteLine(current);
                bool exit = true;

                Console.WriteLine("Введите restart, чтобы начать игру заново.");
                Console.WriteLine("Введите end для выхода...");
                Console.WriteLine();
                while (exit)
                {
                    Console.WriteLine("Введите четырехзначное число:");
                    enter = Console.ReadLine();
                    if (enter == "restart") break;
                    if (enter == "end") return;
                    if (enter.Length != 4)
                    {
                        Console.WriteLine("Число символов введенной строки не равна 4!!!");
                        continue;
                    }
                    try
                    {
                        double temp = Convert.ToDouble(enter.Insert(1, ","));
                    }
                    catch
                    {
                        Console.WriteLine("Число введено не верно!!!");
                        continue;
                    }
                    exit = Compare(enter, current);
                }
            }

        }
    }
}
