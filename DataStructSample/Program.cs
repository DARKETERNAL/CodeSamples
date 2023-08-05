// See https://aka.ms/new-console-template for more information
using DataStructSample;

Console.WriteLine("Hello, World!");

//int[] arr = new int[4]; // Extensión
int[] arr = { 1, 2, 3, 4 }; // Comprensión
//int[] arr = new int[0];

//List<int> list = null;
//List<int> list = new List<int>();
List<int> list = new List<int> { 1, 2, 3, 4 };
//List<int> list = new List<int>(arr);

int[] elements = { 4, 5, 6 };

DataStructTester dataStructSample = new DataStructTester();

List<int> addedList = dataStructSample.AddElements(list, elements);
int[] addedArr = dataStructSample.AddElements(arr, elements);

dataStructSample.IterateList(addedList);
dataStructSample.IterateList(addedArr);