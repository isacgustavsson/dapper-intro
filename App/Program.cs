using Dapper;
using Spectre.Console;

using Model;
using Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        CrudController crud = new();

        crud.Read();

    }
}
