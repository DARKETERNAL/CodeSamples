// See https://aka.ms/new-console-template for more information
using DataStructSample;

Console.WriteLine("cualquiercosaquemediolaganaami");

//int[] arr = new int[4]; // Extensión
int[] arr = { 1, 2, 3, 4 }; // Comprensión
//int[] arr = new int[0];

//List<int> list = null;
//List<int> list = new List<int>();
List<int> list = new List<int> { 1, 2, 3, 4 };
//List<int> list = new List<int>(arr);

Queue<string> queue = new Queue<string>();
Stack<string> stack = new Stack<string>();

string[] strs = { "hola", "adios", "blabla" };

int[] elements = { 4, 5, 6 };

DataStructTester dataStructSample = new DataStructTester();

//List<int> addedList = dataStructSample.AddElements(list, elements);
//int[] addedArr = dataStructSample.AddElements(arr, elements);

//dataStructSample.IterateList(addedList);
//dataStructSample.IterateList(addedArr);

//dataStructSample.Populate(strs, queue);
//dataStructSample.Populate(strs, stack);

//Console.WriteLine($"Element {"hola"} is in queue: {dataStructSample.IsElementInCollection("hola", queue)}");
//Console.WriteLine($"Element {"hola"} is in stack: {dataStructSample.IsElementInCollection("hola", stack)}");

//Console.WriteLine($"Element {"Hola"} is in queue: {dataStructSample.IsElementInCollection("Hola", queue)}");
//Console.WriteLine($"Element {"Hola"} is in stack: {dataStructSample.IsElementInCollection("Hola", stack)}");

Dictionary<int, string> dict = dataStructSample.CreateDictionary(arr, strs);
dataStructSample.PrintDictionary(dict);
Console.WriteLine($"Value {"hola"} is in dict: {dataStructSample.IsValueInDictionary("hola", dict)}");
Console.WriteLine($"Value {"Hola"} is in dict: {dataStructSample.IsValueInDictionary("Hola", dict)}");

dict.TryAdd(4, "cualquierotracosa");

//dict.Add(1, "cualquierotracosa");
dict.TryAdd(1, "cualquierotracosa");
dataStructSample.PrintDictionary(dict);

dict.Remove(1);
dataStructSample.PrintDictionary(dict);

dict.TryAdd(1, "cualquierotracosa");
dataStructSample.PrintDictionary(dict);

dict.Clear();
dataStructSample.PrintDictionary(dict);

//Hola