using System;

namespace PathSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            try
            {
                Console.WriteLine($"Name file without extension: {PathOperation.FileNameWithoutExtencion(path)}");
                Console.WriteLine($"Root foulder name: {PathOperation.RootFoulderName(path)}");
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
