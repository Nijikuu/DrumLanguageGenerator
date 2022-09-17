using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

while (true)
{
    string dlg=File.ReadAllText(@"./drumlanguages.txt");
    JArray arr=JsonConvert.DeserializeObject<JArray>(dlg);
    List<string> list = new();
    foreach (var item in arr)
    {
        list.Add(item.ToString());
    }
    Console.WriteLine("This program does not have an exception handling mechanism, the program crash is not responsible");
    Console.WriteLine($"Please choose a template(0-{list.Count-1})");
    int index = int.Parse(Console.ReadLine().Replace("\n", "").Replace("\r", ""));
    Console.WriteLine("Please enter an overview of the events(use \\n to line break)");
    string sum=Console.ReadLine().Replace("\n","").Replace("\r","").Replace(@"\n","\n");
    Console.WriteLine("Please enter the whole thing(use \\n to line break)");
    string all = Console.ReadLine().Replace("\n", "").Replace("\r", "").Replace(@"\n", "\n");
    Console.WriteLine("Please enter name of the person who you want to persecute(use \\n to line break)");
    string name = Console.ReadLine().Replace("\n", "").Replace("\r", "").Replace(@"\n", "\n");
    string result = list[index].Replace("%name%", name).Replace("%example_sum%",sum).Replace("%example_main%",all);
    Console.WriteLine(result);
    Console.ReadKey();
}