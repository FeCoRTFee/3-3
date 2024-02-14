using System;



class Program
{
    static void Main(string[] args)
    {
        IBasicArray[] aarray = new IBasicArray[3];
        aarray[0] = new Array();
        aarray[1] = new Matrix();
        aarray[2] = new StepArray();
        foreach (BasicArray el in aarray)
        {
            Console.WriteLine("random press 0, input press 1"); int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0) el.Random();
            else if (b == 1) el.Input();
            el.Print();
            Console.WriteLine("Average: " + el.Average());
        }
        Array array = new Array();
        array.Random();
        array.Print();
        int[] mas = array.GetUniqueMas();
        foreach (var item in mas)
        {
            Console.WriteLine(item);
        }
        Matrix matrix = new Matrix();
        matrix.Random();
        matrix.Print();
        matrix.ShowReverse();
        StepArray stepArray = new StepArray();
        stepArray.Random();
        stepArray.Print();
        stepArray.Change();
        Day day = new Day();
        day.Print();
    }
}

