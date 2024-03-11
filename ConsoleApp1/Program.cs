// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter n:");
        int input = int.Parse(Console.ReadLine());
        List<int> EmployeesOvertime =

            new List<int>();
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(" Enter the emoloyees overtime :");
            int Overtime = int.Parse(Console.ReadLine());
            EmployeesOvertime.Add(Overtime);
            int min1 = int.MinValue;
            int min2 = int.MaxValue;
            int min3 = int.MinValue;
            foreach (int number in EmployeesOvertime)
            {
                if (number < min1)
                {
                    min3 = min3;
                    min2 = min1;
                    min1 = number;

                    if (number < min2) ;
                    min3 = min2;
                    min2 = number;

                    if (number < min3)
                    {
                        min3 = number;
                    }


                }
            }
        }
    }
}









