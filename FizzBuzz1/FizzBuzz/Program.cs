using FizzBuzz;

class Program
{
    static void Main()
    {
        FizzBuzzConverter converter = new FizzBuzzConverter();

        for (int i = 0; i < 100; i++)
        {

            converter.CheckIfFizzOrBuzzOrFizzBuzz("", i);
        }
    }
}


