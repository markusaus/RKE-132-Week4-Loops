

int sum = 0;

for (int i = 0 ; i < 10; i++)
{
    Console.WriteLine($"i={i}");
    Console.WriteLine($"current total: {sum}");
    sum = sum + i ; //sum +=1  
}

Console.WriteLine($"Final total {sum}"); 