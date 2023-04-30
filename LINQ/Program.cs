// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine( "Hello, World!" );

List<string> employessNames = new List<string>();
employessNames.Add( "Candince" );
employessNames.Add( "Karl" );
employessNames.Add( "John" );
employessNames.Add( "Cathrine" );
var filteredEmployess = employessNames.Where( emp => emp.StartsWith( 'C' ) == true );

List<int> numbers = new List<int>();
numbers.Add( 1 );
numbers.Add( 2 );
numbers.Add( 3 );
numbers.Add( 4 );
numbers.Add( 5 );
numbers.Add( 6 );
numbers.Add( 7 );
numbers.Add( 8 );
var filteredNumbers = numbers.Check( dig => dig > 5 );
filteredNumbers.ForEach( e => Console.WriteLine( e ) );

List<Employee> employeesList = new List<Employee>();
employeesList.Add( new Employee() { Name = "John", LastName = "Troll", Age = 22 } );
employeesList.Add( new Employee() { Name = "Khon", LastName = "Sron", Age = 52 } );
employeesList.Add( new Employee() { Name = "Tron", LastName = "Kon", Age = 43 } );
employeesList.Add( new Employee() { Name = "Cfon", LastName = "Von", Age = 31 } );

public static class Linq
{
    public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
    {
        List<T> filteredList = new List<T>();

        foreach (T item in records)
        {
            if (func( item ))
            {
                filteredList.Add( item );
            }
        }

        return filteredList;
    }

    public static List<T> Check<T>(this List<T> records, Func<T, bool> func)
    {
        List<T> filteredList = new List<T>();

        foreach (T item in records)
        {
            if (func( item ))
            {
                filteredList.Add( item );
            }
        }

        return filteredList;
    }
}

public class Employee
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        throw new NotImplementedException();
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        throw new NotImplementedException();
    }
}