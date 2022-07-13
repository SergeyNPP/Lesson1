int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = 0;
if( max < b)
    {
    max = b;
    if( max < c)
        {
             max = c;
        }
    }
    else
    {
        if (max <c)
        {
           max = c;
        }

    }
Console.Write("Максимальное ");
Console.Write(max);