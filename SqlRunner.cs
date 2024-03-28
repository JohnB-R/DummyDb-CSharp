using System;

class SqlRunner
{
    public void RunSql()
    {
        LoadDriver();
        ConnectDb();

        // Our aim: to EiTHER write OR read...

        Console.WriteLine("Writing");
        Console.WriteLine("Reading");

        CloseDb();
    }

    void LoadDriver()
    {
        Console.WriteLine("Loading driver");
    }

    void ConnectDb()
    {
        Console.WriteLine("Connecting");
    }

    void CloseDb()
    {
        Console.WriteLine("Closing");
    }
}