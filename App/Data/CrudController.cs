using System.Data;
using Model;
using MySql.Data.MySqlClient;
using Dapper;
using Spectre.Console;

namespace Data;

public class CrudController
{

    //TODO Placeholder kod för att testa att det funkar men denna borde bli mer generell och det man vill selecta borde komma från user-input.
    public void Read()
    {
        DbContext context = new();
        using var connection = context.GetConnectionString();

        string sql = "SELECT * FROM Student";

        IEnumerable<Student> students = connection.Query<Student>(sql);

        foreach (Student s in students)
        {
            AnsiConsole.MarkupLine($"[cyan1]Id: {s.Id}  Name: {s.Name}  Email: {s.Email}  Birthday: {s.DateOfBirth:yyyy-MM-dd}[/]\n");
        }
    }
}