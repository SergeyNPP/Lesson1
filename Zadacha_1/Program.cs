Console.WriteLine("Введи число 1");
// int a = Console.Read();
int a = int.Parse(Console.ReadLine());
// char a = (char)Console.Read();
Console.WriteLine("Введи число 2");
// int c = Console.Read();
// char c = (char)Console.Read();
int c = int.Parse(Console.ReadLine());
if (a < c)
    {
        Console.Write(c);
        Console.Write(" Больше");   
    }
    else    
    {        
        Console.Write(a);
        Console.Write(" Больше"); 
    }

