using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class BasicArray:IPrintable,IBasicArray
{
    protected int number_of_cells;   
    protected BasicArray(int n)
    {
        number_of_cells = n;
    }
    public abstract void Recreate(int n);
    public abstract void Random();
    public abstract void Input();
    public abstract double Average();

    public abstract void Print();
    
        
    
}



