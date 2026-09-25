using Newtonsoft.Json;

var data = new
{
    Student = "Васильева Дарья",
    Group = "УИР-1",
    Lab = "Лабораторная работа №1",
    Technology = "Visual Studio 2022 + C# + Newtonsoft.Json"
};

string json = JsonConvert.SerializeObject(data, Formatting.Indented);

Console.WriteLine("Данные в формате JSON:");
Console.WriteLine(json);
Console.WriteLine();
Console.WriteLine("Лабораторная работа №1 выполнена!");