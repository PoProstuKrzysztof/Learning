//string input = Console.ReadLine() ?? "Basic";
//string result = (input) switch
//{
//    "True" => "Magical True",
//    "False" => "Obnoxious false",
//    "Other" => "Other Fus",
//    "Basic" => "Basic Truth"
//};

//Console.WriteLine(result);

//Person person = new("Jhon");
//Console.WriteLine(nameof(person.firstname));

//public class Person
//{
//    public string firstname { get; set; } = "seba";

//    public Person(string fn)
//    {
//        firstname = fn;
//    }

//    public override string ToString()
//    {
//        return $"First name {firstname}";
//    }
//}

//var result = DoSomething().Skip(2).Take(4).FirstOrDefault();

//Console.WriteLine(string.Join(",", result));

//static IEnumerable<int> DoSomething()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        if (i > 5)
//        {
//            yield break;
//        }

//        yield return i;
//    }
//}

Action<int> consoleWriteLine = n => Console.WriteLine(n);
int i = 10;
Task t1 = Task.Factory.StartNew(() => consoleWriteLine(i));
i = 15;
Task t2 = Task.Factory.StartNew(() => consoleWriteLine(i));
Task.WaitAll(t1, t2);