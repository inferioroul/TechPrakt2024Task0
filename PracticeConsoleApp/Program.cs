bool f;
int IntegerCheck(string str)
{
    int value;
    do
    {
        Console.Write(str);
        f = Int32.TryParse(Console.ReadLine(), out value);
        if (!f)
        {
            Console.WriteLine("Enter an integer!");
        }
    } while(!f);
    return value;
}
int a = IntegerCheck("Enter number a = ");
int b = IntegerCheck("Enter number b = ");
Console.WriteLine($"a + b = {a + b}");