using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running version <You think of a number>");
        SqlRunner sqlRunner = new SqlRunner();
        sqlRunner.RunSql(); // We want to make RunSql WRITE

        Console.WriteLine("...");

        sqlRunner.RunSql(); // We want to make RunSql READ
    }
}

/* The output should be

Loading driver
Connecting
Writing
Closing
...
Loading driver
Connecting
Reading
Closing

*/