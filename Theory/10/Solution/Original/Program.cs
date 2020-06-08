using System;

class Program
{
    public static void Main()
    {
        var instruction = new Instructions();
        string code = Console.ReadLine();
        while (code != "END")
        {
            //Console.WriteLine(instruction.Exec(code));
            Console.WriteLine(instruction.Execute(code));
            code = Console.ReadLine();
        }
    }
}