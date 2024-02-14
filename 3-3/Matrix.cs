using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix : BasicArray
{
    int[,] mas;
    public Matrix(int n = 3) : base(n)
    {
        mas = new int[number_of_cells,number_of_cells];

    }
    public override void Input()
    {
        Console.WriteLine("Enter rows number");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter columns number");
        int columns = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows, columns];
        Console.WriteLine("Enter elements");
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mas[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }

    public override double Average()
    {
        int sum = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                sum += mas[i, j]; 
            }

        }
        return sum / (mas.GetLength(0) * mas.GetLength(1));
    }
    public override void Print()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }

    public override void Random()
    {
        Random rnd = new Random();
        Console.WriteLine("Enter rows number");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter columns number");
        int columns = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mas[i, j] = rnd.Next(-100, 100);
            }

        }
    }

    public override void Recreate(int n)
    {
        mas = new int[number_of_cells, number_of_cells];
    }
    public void ShowReverse()
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
            }
            else
            {
                for (int j = mas.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(mas[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

