// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static void Main (string[]args)
{
    Console.Write("Introduce un numero entero");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1 ; i <= num; i++)
    {
        for (int h = 1; h <= i; h++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
