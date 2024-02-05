List<string> list = new List<string>() { "text0" };
// list text0
List<string> list2 = GenerateList(list.ToArray());
//list2 text0 AddText1
List<string> list3 = GenerateListFromList(list);
//list3 text0 AddText2
List<string> list4 = GenerateListFromList(list.ToList());
//list4 text0 AddText2
list.Add("text2");

//list text0 AddText2 text2
Console.WriteLine(list.Equals(list2));
Console.WriteLine(list.Equals(list3));
Console.WriteLine(list.Equals(list4));
Console.ReadLine();

static List<string> GenerateList(string[] arr)
{
    var list = arr.ToList();
    list.Add("AddText1");
    return list;
}

static List<string> GenerateListFromList(List<string> list)
{
    list.Add("AddText2");
    return list;
}