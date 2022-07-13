int a = int.Parse(Console.ReadLine());
int b = a % 2;
if (b > 0)
    {
        a = (a-1);
        while ( a > 0)
            {
                Console.Write(a);
                Console.Write(" ");
                a=a-2;
            } 
    }
    else    
    {    
        while ( a > 0) 
        {   
        Console.Write(a);
        Console.Write(" ");
        a=a-2;
        }
    }