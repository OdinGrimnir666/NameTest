using Name_Test;

Console.WriteLine("Введіть ім'я та прізвище:");
string fullName = Console.ReadLine();

string formattedName = NameDelimiter.FormatName(fullName);
Console.WriteLine("Відформатоване ім'я та прізвище: " + formattedName);

Console.ReadKey();