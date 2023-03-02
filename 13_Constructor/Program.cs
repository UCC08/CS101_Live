using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
        clsTest test=new clsTest();

        Console.WriteLine($"i değeri {test.i} - s değeri {test.s} - b değeri {test.b} ");



        Console.ReadKey();
    }
}