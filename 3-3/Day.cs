using System;

internal class Day : IPrintable
{
    DateTime date;
    int dayofweek;
    public void Print()
    {
        date = DateTime.Now;
        dayofweek = (int)date.DayOfWeek;
        Console.WriteLine(dayofweek + " номер дня недели");
    }
}

