using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StepArray : BasicArray,IPrintable
{
    int[][] mas;
    public StepArray(int n = 3) : base(n)
    {
        mas = new int[number_of_cells][];

    }
    public override void Input()
    {
        Console.WriteLine("Enter rows number");
        int rows = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Enter line");
            string line = Console.ReadLine();
            string[] elements = line.Split(' ');
            int[] mas1 = new int[elements.Length];
            for (int j = 0; j < mas1.Length; j++)
            {
                mas1[j] = Int32.Parse(elements[j]);

            }
            mas[i] = mas1;

        }
    }

    public override double Average()
    {
        double s = 0;
        int c = 0;
        foreach (int[] row in mas)
        {
            foreach (int number in row)
            {
                s += number;
                c++;

            }

        }
        return s /= c;
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        foreach (int[] row in mas)
        {
            foreach (int number in row)
            {
                Console.Write(number + " ");

            }
            Console.WriteLine();
        }
    }

    public override void Random()
    {
        Console.WriteLine("Enter rows number");
        int rows = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows][];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            int columns = rnd.Next(1, 10);
            int[] smas = new int[columns];
            for (int j = 0; j < smas.Length; j++)
            {
                smas[j] = rnd.Next(-1001, 1001);
            }
            mas[i] = smas;
        }
    }

    public override void Recreate(int n)
    {
        mas = new int[number_of_cells][];
    }
    public void Change()
    {
        Console.WriteLine("Change");
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < mas[i].Length; j++)
            {
                if (mas[i][j] % 2 == 0)
                {
                    mas[i][j] = i * j;
                }
                Console.Write(mas[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}


