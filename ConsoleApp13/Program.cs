int[] nums = {1, 2, 3, 4, 5, 6, 7};
Array<int> numm = new Array<int>(nums);
numm.AddData(9, 3);
numm.Print();
numm.ReplaceData(3, 6);
numm.Print();
numm.RemoveData(5);
numm.Print();
Console.WriteLine(numm.GetByIndex(4));
Console.WriteLine(numm.GetLength());
class Array<B>
{
    public void AddData(B value, int index) 
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        else if (index > Ar.Length)
        {
            B[] temp = new B[index];
            for (int i = 0; i < Ar.Length; i++)
            {
                temp[i] = Ar[i];
            }
            temp[index - 1] = value;
            Ar = temp;
        }
        else
        {
            B[] temp = new B[Ar.Length + 1];
            for (int i = 0; i < index - 1; i++)
            {
                temp[i] = Ar[i];
            }
            temp[index - 1] = value;
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = Ar[i - 1];
            }
            Ar = temp;
        }
    }
    public void ReplaceData(B value, int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        else if (index > Ar.Length)
        {
            Console.WriteLine("Use AddData method");
        }
        else
        {
            Ar[index - 1] = value;
        }

    }
    public void RemoveData(int index) 
    {
        if (index < Ar.Length)
        {
            B[] temp = new B[Ar.Length - 1];
            for (int i = 0; i < index - 1; i++)
            {
                temp[i] = Ar[i];
            }
            for (int i = index-1; i < Ar.Length - 1; i++)
            {
                temp[i] = Ar[i+1];
            }
            Ar = temp;
        }
        else Console.WriteLine("Write correct index");
    }
    public B GetByIndex(int index) 
    {
         return Ar[index-1];  
    }
    public int GetLength() 
    {
        return Ar.Length;
    }
    public void Print()
    {
        Console.Write("{");
        foreach (B value in Ar)
        {
            Console.Write(value.ToString());
        }
        Console.Write("}");
    }
    public B[] Ar;
    public Array (B[] array)
    {
        Ar = array;
    }
}