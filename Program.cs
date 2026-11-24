//string name = "   Анна Иванова   ";

//Console.WriteLine($"Исходная строка: [{name}]");

//string cleanedName = name.Trim();

//Console.WriteLine($"После Trim: [{cleanedName}]");
//Console.WriteLine($"Верхний регистр: {cleanedName.//ToUpper()}");
//Console.WriteLine($"Нижний регистр: {cleanedName.//ToLower()}");

//string text = "   Я ИЗУЧАЮ C#   ";
//Console.WriteLine(text.Trim().ToLower());


// string message = "Я изучаю C# и Python, и это круто";

// Console.WriteLine(message.Contains("C#"));
// Console.WriteLine(message.Contains("Python"));
// Console.WriteLine(message.StartsWith("Я"));
// Console.WriteLine(message.EndsWith("программы"));

// 
string message = "яблоко,груша,яблоко";
string newMessage =
message.Replace("яблоко", "апельсин");
Console.WriteLine(newMessage);
